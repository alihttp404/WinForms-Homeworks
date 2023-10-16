using BakuLondon.Properties;

namespace BakuLondon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            CityPic.Image = Resources.baku;
            TimeTextBox.Text = DateTime.Now.ToString();
        }

        private void LondonBtn_Click(object sender, EventArgs e)
        {
            CityPic.Image = Resources.london;
            TimeTextBox.Text = DateTime.Now.AddHours(-4).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CityPic.Image = Resources.baku;
            TimeTextBox.Text = DateTime.Now.ToString();
        }
    }
}