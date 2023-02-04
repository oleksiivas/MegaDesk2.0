using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Earl
{
    public partial class ViewAllQuotes : Form
    {
        private List<DeskQuote> quotes;
        public ViewAllQuotes(List<DeskQuote> quotes)
        {
            InitializeComponent();
            this.quotes = quotes;

        }
        private List<DeskQuote> GetDeskQuotes()
        {
            //List<DeskQuote> test = new List<DeskQuote>();
            //Desk test1 = new Desk(24, 48, Material.ROSEWOOD, 2);
            //DeskQuote quote1 = new DeskQuote(test1, 14, "Start", "Last");
            //test.Add(quote1);
            // return test;
            return this.quotes;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = GetDeskQuotes();
            //DataGridViewTextBoxColumn fName = new DataGridViewTextBoxColumn();
            //fName.DataPropertyName = "FirstName";
            //fName.HeaderText = "First Name";
            //fName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns.Add(fName);

            //DataGridViewTextBoxColumn lName = new DataGridViewTextBoxColumn();
            //lName.DataPropertyName = "LastName";
            //lName.HeaderText = "Last Name";
            //lName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns.Add(lName);

            //DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            //date.DataPropertyName = "Date";
            //date.HeaderText = "Date";
            //date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns.Add(date);

            //DataGridViewTextBoxColumn total = new DataGridViewTextBoxColumn();
            //total.DataPropertyName = "Total";
            //total.HeaderText = "Total";
            //total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns.Add(total);

            //DataGridViewTextBoxColumn area = new DataGridViewTextBoxColumn();
            //area.DataPropertyName = "Area";
            //area.HeaderText = "Area";
            //area.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns.Add(area);
        

            //DataGridViewTextBoxColumn drawers = new DataGridViewTextBoxColumn();
            //drawers.DataPropertyName = "Drawers";
            //drawers.HeaderText = "Drawers";
            //drawers.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns.Add(drawers);

            //DataGridViewTextBoxColumn material = new DataGridViewTextBoxColumn();
            //material.DataPropertyName = "Material";
            //material.HeaderText = "Material";
            //material.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns.Add(material);

            var bindingList = new BindingList<DeskQuote>(quotes);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            //dataGridView1.Refresh();
        }
    }
}
