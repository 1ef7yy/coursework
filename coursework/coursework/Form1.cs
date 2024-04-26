namespace coursework
{
    public partial class Form1 : Form
    {
        public Form1()
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