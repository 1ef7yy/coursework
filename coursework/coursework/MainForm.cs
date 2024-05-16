namespace coursework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {

            CartForm cartForm = new CartForm();
            cartForm.Show();

            this.Hide();
        }

        protected override void OnClosed(EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}