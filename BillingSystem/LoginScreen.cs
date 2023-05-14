namespace BillingSystem
{
    public partial class LoginScreen : Form
    {
        int aux;
        bool confirmation;
        string useradmin;
        string passwordadmin;
        bool userConfirmation;
        string[] userarr = new string[5];
        string[] passarr = new string[5];


        public LoginScreen(string[] userarr, string[] passarr, int aux)
        {
            this.useradmin = "admin";
            this.passwordadmin = "admin";
            this.confirmation = false;
            this.userConfirmation = false;

            this.userarr = userarr;
            this.passarr = passarr;
            this.aux = aux;


            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }


        /*============================= Code ============================*/
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = UserBox;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

            if (UserBox.Text == this.useradmin || PasswordBox.Text == this.passwordadmin)
            {
                if (UserBox.Text != useradmin || PasswordBox.Text != passwordadmin)
                {
                    MessageBox.Show("Wrong username or password. Try again.");
                    UserBox.Clear();
                    PasswordBox.Clear();
                    UserBox.Focus();
                }
                else
                {
                    userConfirmation = true;
                    this.Hide();
                    UserBox.Clear();
                    PasswordBox.Clear();
                    PrincipalScreen principalscreen = new PrincipalScreen(this.userarr, this.passarr, this.aux, this.userConfirmation);
                    principalscreen.ShowDialog();
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (UserBox.Text == this.userarr[i] && PasswordBox.Text == this.passarr[i])
                    {
                        this.Hide();
                        UserBox.Clear();
                        PasswordBox.Clear();
                        PrincipalScreen principalscreen = new PrincipalScreen(this.userarr, this.passarr, this.aux, this.userConfirmation);
                        principalscreen.Show();
                        this.confirmation = true;
                        break;
                    }
                }
                if (this.confirmation == false)
                {
                    MessageBox.Show("Wrong username or password. Try again.");
                    UserBox.Clear();
                    PasswordBox.Clear();
                    UserBox.Focus();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserBox.Clear();
            PasswordBox.Clear();
            RegisterScreen registerScreen = new RegisterScreen(this.userarr, this.passarr, this.aux, this.useradmin);
            registerScreen.ShowDialog();
        }
    }
}