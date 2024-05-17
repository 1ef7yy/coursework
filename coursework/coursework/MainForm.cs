namespace coursework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            beefPrice.Text = Cart.Prices["beef"].ToString() + "₽";
            eggsPrice.Text = Cart.Prices["eggs"].ToString() + "₽";
            pearPrice.Text = Cart.Prices["pear"].ToString() + "₽";
            oreshkiPrice.Text = Cart.Prices["oreshki"].ToString() + "₽";
            waterPrice.Text = Cart.Prices["water"].ToString() + "₽";
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            Item beef = new Item("Мясо", Cart.Prices["beef"], (int)beefSelect.Value);
            Item eggs = new Item("Яйца", Cart.Prices["eggs"], (int)eggsSelect.Value);
            Item pears = new Item("Груши", Cart.Prices["pear"], (int)pearSelect.Value);
            Item oreshki = new Item("Орешки", Cart.Prices["oreshki"], (int)oreshkiSelect.Value);
            Item water = new Item("Вода", Cart.Prices["water"], (int)waterSelect.Value);

            Cart.items.Add(beef);
            Cart.items.Add(eggs);
            Cart.items.Add(pears);
            Cart.items.Add(water);
            Cart.items.Add(oreshki);

            int sum = Cart.items.Sum(x => Convert.ToInt32(x.Price*x.Amount));
            
            Cart.sum = sum;



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