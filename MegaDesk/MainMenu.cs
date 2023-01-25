namespace MegaDesk_Earl
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowSearchQuotesForm(object sender, EventArgs e)
        {
            SearchQuotes searchForm = new SearchQuotes();
            searchForm.Tag = this;
            searchForm.Show(this);
            this.Hide();
        }

        private void AddNewQuote(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show(this);
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            List<DeskQuote> list = new List<DeskQuote>();
            ViewAllQuotes quotes = new ViewAllQuotes(list);
            quotes.Show(this);
        }
    }
}