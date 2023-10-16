namespace Running_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            int maxX = this.Width - label1.Width;
            int maxY = this.Height - label1.Height;

            // Generate random X and Y coordinates within the form's client area
            int newX = Random.Shared.Next(maxX);
            int newY = Random.Shared.Next(maxY);

            label1.Location = new Point(newX, newY);
        }
    }
}