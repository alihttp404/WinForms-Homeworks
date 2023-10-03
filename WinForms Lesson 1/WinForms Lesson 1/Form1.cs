using System.Text.Json;
using System.Windows.Forms;
using WinForms_Lesson_1.Properties;

namespace WinForms_Lesson_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button asdf = new Button();
            asdf.Text = ((Form1)sender).Text;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of HttpClient
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "http://worldtimeapi.org/api/timezone/Asia/Baku";

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        MyTimeZone data = JsonSerializer.Deserialize<MyTimeZone>(content);
                        string dateTimeString = data.datetime;
                        DateTime dateTime = DateTime.Parse(dateTimeString);

                        TimeTextbox.Text = dateTime.ToString("HH:mm:ss");

                        Image newImage = Image.FromFile("C:/Users/mamma_er07/Downloads/baku.jpg");
                        PicOfCurrCity.Image = newImage;
                    }
                    else
                    {
                        TimeTextbox.Text = $"API request failed with status code {response.StatusCode}";
                    }
                }
            }
            catch (Exception ex)
            {
                TimeTextbox.Text = $"An error occurred: {ex.Message}";
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "http://worldtimeapi.org/api/timezone/Europe/London";

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        MyTimeZone data = JsonSerializer.Deserialize<MyTimeZone>(content);
                        string dateTimeString = data.datetime;
                        DateTime dateTime = DateTime.Parse(dateTimeString);

                        TimeTextbox.Text = dateTime.ToString("HH:mm:ss");

                        Image newImage = Image.FromFile("C:/Users/mamma_er07/Downloads/london.jpg");
                        PicOfCurrCity.Image = newImage;
                    }
                }
            }
            catch (Exception ex)
            {
                TimeTextbox.Text = $"An error occurred: {ex.Message}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}