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
    public partial class SearchQuotes : Form
    {
        private List<DeskQuote> quotes;

        public SearchQuotes(List<DeskQuote> quotes)
        {
            InitializeComponent();
            this.quotes = quotes;
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            var bindingList = new BindingList<DeskQuote>(quotes);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void lastNameSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = lastNameSearch.Text;

            var filteredList = quotes.FindAll(quote => quote.LastName.Contains(searchValue));
            var bindingList = new BindingList<DeskQuote>(filteredList);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
