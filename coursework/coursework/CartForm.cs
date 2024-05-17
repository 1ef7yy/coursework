using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class CartForm : Form
    {
        public CartForm()
        {

            InitializeComponent();
            cartSum.Text = $"{User.name}, ваша сумма заказа: {Cart.sum.ToString()}₽\nВаш адрес доставки: {User.address}";

        }

        protected override void OnClosed(EventArgs e)
        {
            Cart.sum = 0;
            Cart.items.Clear();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            string mail_text =  $"""
                У вас новый заказ от {User.name} по адресу {User.address}
                Номер для связи: {User.phone}

                В заказе {getOrder()}

                Доставить {timeSelect.Text}
                """;

            MailHandler mailHandler = new MailHandler();

            mailHandler.SendMail(Config.mail_to, mail_text);

            orderBtn.Text = "Заказ отправлен!";
            orderBtn.Enabled = false;

        }

        private string getOrder()
        {

            string final_order = "";
            List<Item> items = Cart.items;

            for (int i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                if (item.Amount > 0)
                {
                    final_order += $"\n{item.Amount} шт. {item.Name}";
                }
            }
            return final_order;
        }
    }
}
