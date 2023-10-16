namespace WinForms_HW1
{
    public partial class Form1 : Form
    {
        private Point pointA;
        private Point pointB;
        private Label label;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label = new Label
            {
                BorderStyle = BorderStyle.FixedSingle,
                Text = "Label"
            };

            this.Controls.Add(label);

            label.MouseDown += Label_MouseDown;
            label.MouseMove += Label_MouseMove;
            label.MouseUp += Label_MouseUp;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointA = e.Location;
                label.Location = pointA;
            }
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointB = e.Location;
                int width = Math.Abs(pointB.X - pointA.X);
                int height = Math.Abs(pointB.Y - pointA.Y);

                label.Size = new Size(width, height);

                label.Location = new Point(
                    Math.Min(pointA.X, pointB.X),
                    Math.Min(pointA.Y, pointB.Y)
                );
            }
        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointB = e.Location;
            }
        }
    }
}