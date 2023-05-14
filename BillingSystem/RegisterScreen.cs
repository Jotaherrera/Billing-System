using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class RegisterScreen : Form
    {
        int aux;
        string useradmin;
        string[] userarr = new string[5];
        string[] passarr = new string[5];

        public RegisterScreen(string[] userarr, string[] passarr, int aux2, string useradmin)
        {
            this.aux = aux2;
            this.useradmin = useradmin;
            this.userarr = userarr;
            this.passarr = passarr;

            InitializeComponent();
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }


        /*============================= Code ============================*/

        private void CancelRegisterButton_Click(object sender, EventArgs e)
        {

            LoginScreen loginscreen = new LoginScreen(this.userarr, this.passarr, this.aux);
            loginscreen.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {


            if (UserBox.Text.Length < 3)
            {
                MessageBox.Show("The username is too short. Try another.");
            }
            else if (PasswordBox.Text.Length < 3)
            {
                MessageBox.Show("The password is too short. Try another.");
            }
            else if (this.userarr.Contains(UserBox.Text) || UserBox.Text == useradmin)
            {
                MessageBox.Show("That username is taken. Try another.");
            }
            else if (this.aux == 5)
            {
                MessageBox.Show("The maximum number of registered users has been reached. Sorry.");
            }
            else if (UserBox.Text.Length >= 3 && PasswordBox.Text.Length >= 3 && this.aux <= 5)
            {
                this.userarr[this.aux] = UserBox.Text;
                this.passarr[this.aux] = PasswordBox.Text;

                aux += 1;

                MessageBox.Show("User registered successfully.");

                LoginScreen loginscreen = new LoginScreen(this.userarr, this.passarr, this.aux);
                loginscreen.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong. Try again.");
            }
        }
    }
}
