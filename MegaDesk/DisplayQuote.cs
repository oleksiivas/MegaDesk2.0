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
    public partial class DisplayQuote : Form
    {
        private DeskQuote quote;
        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            this.quote = quote;
            CustomerText.Text = $"{quote.getCustFirstName()} {quote.getCustLastName()}";
            CostText.Text = $"{quote.getTotalPrice()}";
            DateText.Text = $"{quote.getDate()}";
            rushOrderCostText.Text = $"{quote.getRushOrderPrice()}";
            baseCostText.Text = $"{quote.getBasePrice()}";
            surfaceAreaCostText.Text = $"{quote.getAreaPrice()}";
            drawerCostText.Text = $"{quote.getDrawerPrice()}";
            materialCostText.Text = $"{quote.getSurfacePrice()}";
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainMenu menu = (MainMenu)Tag;
                menu.Show();
                Close();
            }catch(Exception ex)
            {
                //Tag is probably null... we need to fix this.
                //Recreate the instance, and warn.
                MessageBox.Show(ex.Message);
                MainMenu main = new MainMenu();
                main.Show();
                Close();
            }
            
        }
    }
}
