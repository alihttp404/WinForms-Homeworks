namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int a = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text)) UsernameTextBox.Text = "Enter your username";
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.Text = "Enter your password";
            }

            else PasswordTextBox.PasswordChar = '*';
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.Text = "Enter your password";
            }
            else if (!string.IsNullOrEmpty(PasswordTextBox.Text) && PasswordTextBox.Text != "Enter your password")
                PasswordTextBox.PasswordChar = '*';
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (a == 0)
            {
                UsernameTextBox.Text = "Enter your username";
                a++;
            }

            else if (a != 0 && UsernameTextBox.Text == "Enter your username")
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}