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

namespace Věc_během_hodiny
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
           






        }
                    
        









        public void RED(object sender, RoutedEventArgs e)
        {
            //imgObrazek.Source = "/C:\Users\michal.patkolo\Desktop\barvy"
            //imgObrazek.Source = "images/...";

            imgObrazek.Source = new BitmapImage(new (@"images/RED.jpg",UriKind.Relative));
            
        }

        public void BLUE(object sender, RoutedEventArgs e)
        {
            imgObrazek.Source = new BitmapImage(new(@"images/BLUE.png", UriKind.Relative));
        }

        public void BLACK(object sender, RoutedEventArgs e)
        {
            imgObrazek.Source = new BitmapImage(new(@"images/BLACK.jfif", UriKind.Relative));
        }
    }
}
