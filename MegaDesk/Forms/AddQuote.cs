using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Earl
{
    
    public partial class AddQuote : Form
    {
        public List<DeskQuote> deskQuotes { get; set; }

        public AddQuote(List<DeskQuote> quotes)
        {
            InitializeComponent();
            deskQuotes = quotes;

            var datasource = new List<MaterialSelection>();
            foreach(var mat in Enum.GetNames(typeof(Material))){
                datasource.Add(new MaterialSelection() { Name = mat, Value = (Material)Enum.Parse(typeof(Material), mat) });
            }
            
            surfaceComboBox.DataSource = datasource;
            surfaceComboBox.DisplayMember = "Name";
            surfaceComboBox.ValueMember= "Value";
            widthControl.Maximum = Desk.maxWidth;
            widthControl.Minimum = Desk.minWidth;
            depthControl.Maximum = Desk.maxDepth;
            depthControl.Minimum = Desk.minDepth;
            drawersControl.Maximum = Desk.maxDrawers;
            drawersControl.Minimum = Desk.minDrawers;
            widthLimitText.Text = $"{Desk.minWidth} - {Desk.maxWidth} in";
            depthLimitText.Text = $"{Desk.minDepth} - {Desk.maxDepth} in";
            drawerLimitText.Text = $"{Desk.minDrawers} - {Desk.maxDrawers} Drawers";
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReturnToMenu(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
        private int getRushOrder()
        {
            if (rushOrder14Days.Checked)
            {
                return 14;
            }else if (rushOrder7Days.Checked)
            {
                return 7;
            }else if (rushOrder5Days.Checked)
            {
                return 5;
            }else
            {
                // rushorder 3 is the only one left to be selected.
                return 3;
            }
        }

        private bool checkNameInputs() { 
            return checkFirstName() && checkLastName();
        }
        private bool checkFirstName()
        {
            return FirstNameBox.Text.Trim() != "";
        }
        private bool checkLastName()
        {
            return LastNameBox.Text.Trim() != "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkNameInputs())
            {
                Warning.Text = "First and Last name Must be filled.";
                if (!checkFirstName())
                {
                    FirstNameBox.BackColor = Color.Pink;

                }
                if (!checkLastName())
                {
                    LastNameBox.BackColor = Color.Pink;

                }
            }
            else
            {
                Warning.Text = "";
                FirstNameBox.BackColor = Color.White;
                LastNameBox.BackColor = Color.White;
                Desk desk = new Desk((int)widthControl.Value, (int)depthControl.Value, (Material)surfaceComboBox.SelectedValue, (int)drawersControl.Value);
                
                DeskQuote quote = new DeskQuote()
                {
                    FirstName = FirstNameBox.Text,
                    LastName = LastNameBox.Text,
                    RushOrder = getRushOrder(),
                    Desk = desk
                };
                
                deskQuotes.Add(quote);
                File.WriteAllText(@"Data\quotes.json", JsonConvert.SerializeObject(deskQuotes));

                DisplayQuote form = new DisplayQuote(quote);
                form.Tag = this.Tag;
                form.Show();
                Close();

            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if(box.Text.Trim() == "")
            {
                box.BackColor = Color.Pink;
            }
            else
            {
                box.BackColor = Color.White;
            }
        }
    }
    public class MaterialSelection
    {
        public string Name { get; set; }
        public Material Value { get; set; }

    }
}
