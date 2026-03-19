using System.Windows;

namespace DoubleNumberApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoubleButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NumberTextBox.Text, out int number))
            {
                DoubleButton.Content = "Я такое не удваиваю";
                return;
            }

            number *= 2;
            NumberTextBox.Text = number.ToString();

            if (number > 77)
            {
                DoubleButton.Content = "Слишком много для меня";
                DoubleButton.IsEnabled = false;
            }
            else
            {
                DoubleButton.Content = "Удвоить";
            }
        }
    }
}