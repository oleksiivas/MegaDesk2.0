using Newtonsoft.Json;

namespace MegaDesk_Earl
{
    public partial class MainMenu : Form
    {
        List<DeskQuote> quotes { get; set; }

        public MainMenu()
        {
            var json = File.ReadAllText("quotes.json");
            quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

            InitializeComponent();
        }

        private void exit(object sender, EventArgs e)
        {
            File.WriteAllText("quotes.json", JsonConvert.SerializeObject(quotes));
            Application.Exit();
        }

        private void ShowSearchQuotesForm(object sender, EventArgs e)
        {
            SearchQuotes searchForm = new SearchQuotes();
            searchForm.Tag = this;
            searchForm.Show(this);
            //this.Hide();
        }

        private void AddNewQuote(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote(quotes);
            addQuoteForm.Tag = this;
            addQuoteForm.Show(this);
            //this.Hide();
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