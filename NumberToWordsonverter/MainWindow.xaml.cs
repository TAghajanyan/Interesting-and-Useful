using System;
using System.Linq;
using System.Windows;

namespace NumberToWordsonverter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            errorMsg.Text = string.Empty;
            words.Text = string.Empty;
            string lng = "ARM";
            string word = null;

            if (Btn1.IsChecked == true)
                lng = "ARM";
            else if (Btn2.IsChecked == true)
                lng = "RU";
            else if (Btn3.IsChecked == true)
                lng = "EN";

            try
            {
                Converter converter = new Converter(lng);

                word = converter.ProcessConversion(number.Text).Words;

            }
            catch (Exception)
            {
                errorMsg.Text = "Input string was not in a correct format!";
                return;
            }

            words.Text = FixWords(word);

        }
        private string FixWords(string words)
        {
            if (words.Contains("Մեկ Հազար"))
            {
                words = words.Replace("Մեկ Հազար", "Հազար");
            }

            if (words.Contains("Մեկ Հարյուր"))
            {
                words = words.Replace("Մեկ Հարյուր", "Հարյուր");
            }

            if (words.Contains("Один Тысяча"))
            {
                words = words.Replace("Один Тысяча", "Тысяча");
            }

            if (words.Contains("Один Сто"))
            {
                words = words.Replace("Один Сто", "Сто");
            }

            return words;
        }
    }
}
