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

namespace Browser
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

        public MainWindow(object sender, EventArgs e)
        {
            dipusbrowser.Source = new Uri("https://www.google.com");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dipusbrowser.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                dipusbrowser.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                dipusbrowser.Source = new Uri("https://" + Search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
