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

namespace ColorButton
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
        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = (sender as Button).Content.ToString();
            this.stcp1.Children.Remove((sender as Button));
            this.stcp2.Children.Remove((sender as Button));
        }
    Random r = new Random();
    private void MouseLeftButtonDown1(object sender, RoutedEventArgs e)
    {
        Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
        (sender as Button).Background = brush;
        MessageBox.Show($"{(sender as Button).Name} {brush}");
    }
}
}
