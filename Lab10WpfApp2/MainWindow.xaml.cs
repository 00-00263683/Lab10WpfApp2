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

namespace Lab10WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sUri = string.Format("data/1.jpg");
            Uri src = new Uri(sUri, UriKind.Relative);
            var bmp = new BitmapImage(src);
            myImage.Source = bmp;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string sUri = string.Format("data/2.jpg");
            Uri src = new Uri(sUri, UriKind.Relative);
            var bmp = new BitmapImage(src);
            myImage.Source = bmp;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string sUri = string.Format("data/3.jpg");
            Uri src = new Uri(sUri, UriKind.Relative);
            var bmp = new BitmapImage(src);
            myImage.Source = bmp;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string sUri = string.Format("data/4.jpg");
            Uri src = new Uri(sUri, UriKind.Relative);
            var bmp = new BitmapImage(src);
            myImage.Source = bmp;
        }
    }
}
