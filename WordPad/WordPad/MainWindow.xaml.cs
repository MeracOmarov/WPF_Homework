using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WordPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool sweetch = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sweetch)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == true)
                {
                    string filePath = saveFileDialog.FileName;
                    string content = TextBox1.Text;

                    File.WriteAllText(filePath, content);
                }
                sweetch = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                string content = File.ReadAllText(filePath);
                TextBox2.Text=filePath;

                TextBox1.Text = content;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(sweetch==false)
            {
                if (CheckBox1.IsChecked == true)
                {
                    TextBox1.TextChanged += TextBox1_TextChanged;
                }
                else
                {
                    TextBox1.TextChanged -= TextBox1_TextChanged;
                }
            }
            else
            {
                Button_Click(sender,e);
            }
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Otomatik kaydetme işlemi burada gerçekleştirilir
            string content = TextBox1.Text;
            string filePath = TextBox1.Text; // Kaydedilecek dosyanın yolunu belirtin
            File.WriteAllText(filePath, content);
        }
       
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.SelectedText))
            {
                Clipboard.SetText(TextBox1.SelectedText);
                TextBox1.SelectedText = string.Empty;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.SelectedText))
            {
                Clipboard.SetText(TextBox1.SelectedText);
                
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                TextBox1.Text = clipboardText;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox1.SelectAll();
        }
    }
}
