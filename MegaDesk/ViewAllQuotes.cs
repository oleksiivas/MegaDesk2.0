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
        public ViewAllQuotes(List<DeskQuote> quotes)
        {
            InitializeComponent();

        }
        private List<DeskQuote> GetDeskQuotes()
        {
            List<DeskQuote> test = new List<DeskQuote>();
            Desk test1 = new Desk(24, 48, Material.ROSEWOOD, 2);
            DeskQuote quote1 = new DeskQuote(test1, 14, "Start", "Last");
            test.Add(quote1);
            return test;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDeskQuotes();
           
        }
    }
}
