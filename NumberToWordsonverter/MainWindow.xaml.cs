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
            var strArr = words.Remove(0, 1).Split(' ');

            // 4-9
            if (strArr.Length >= 4 && strArr.Length <= 9)
            {
                if (strArr[0] == "Մեկ" || strArr[0] == "Один")
                {
                    strArr = strArr.Skip(1).ToArray();
                }
            }

            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] += " ";
            }

            return string.Concat(strArr);
        }
    }
}
