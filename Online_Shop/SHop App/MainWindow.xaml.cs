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

namespace SHop_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window window = null;
        Window window2 = null;
        ListBox listBox = new ListBox();
        Label label = new Label();
        int hesab;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("Cocola");
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (window == null || !window.IsVisible)
            {
                window = new Window() { Width = 300, Height = 300};
                window.Content=listBox;
            }
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("Doner");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("Pide");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("Kabab");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            foreach (var item in listBox.Items)
            {
                if(item.ToString()== "Cocola") 
                {
                    hesab = +1;
                }
                else if(item.ToString() == "Doner")
                {
                    hesab = +2;
                }
                else if (item.ToString() == "Pide")
                {
                    hesab= +3;
                }
                else if (item.ToString() == "Kabab")
                {
                    hesab=+4;
                }
            }
            label.Content = $"SIZIN HESABINIZ {hesab} AZN dir";

            if (window == null || !window.IsVisible)
            {
                window = new Window() { Width = 300, Height = 300 };
                window.Content = label;
            }
            window.Show();
        }
    }
}
