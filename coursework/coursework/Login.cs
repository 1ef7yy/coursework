using System;
using System.Text.RegularExpressions;



namespace coursework
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }


        public void submitButton_Click(object sender, EventArgs e)
        {
            string name = usernameInput.Text;
            string phoneNumber = phoneInput.Text;
            string address = addressInput.Text;



            bool inputs_empty = true;

            string name_regex = "^[A-ЯЁа-яё ]+$";
            string phone_regex = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";


            if (name != null && phoneNumber != null && address != null && consentBox.Checked)
            {
                inputs_empty = false;
            }
            else
            {
                MessageBox.Show("Введите все поля и нажмите галочку", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!inputs_empty)
            {
                if (Regex.IsMatch(name, name_regex) && Regex.IsMatch(phoneNumber, phone_regex))
                {
                    User.name = name;
                    User.address = address;
                    User.phone = phoneNumber;

                    usernameInput.IsAccessible = false;
                    phoneInput.IsAccessible = false;
                    addressInput.IsAccessible = false;

                    progressBar.Visible = true;

                    Random rnd = new Random();

                    while (progressBar.Value <= 100)
                    {
                        int random_value = rnd.Next(3, 15);
                        if (progressBar.Value + random_value > 100)
                        {
                            progressBar.Value = 100;
                            break;
                        }
                        else
                        {
                            progressBar.Value += random_value;
                        }

                        Thread.Sleep(rnd.Next(100, 500));

                    }

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Введите значения правильного формата!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }




        }

    }
}
