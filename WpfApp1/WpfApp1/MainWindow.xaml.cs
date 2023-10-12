using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            byte[] colors = new byte[3];
            colors[0] = (byte)Random.Shared.Next(0, 255);
            colors[1] = (byte)Random.Shared.Next(0, 255);
            colors[2] = (byte)Random.Shared.Next(0, 255);

            this.Background = new SolidColorBrush(Color.FromRgb(colors[0], colors[1], colors[2]));
        }
    }
}
