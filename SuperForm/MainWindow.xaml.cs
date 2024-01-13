using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperForm
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

        private string gender = string.Empty;

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            string firstName = fname.Text;
            string lastName = lname.Text;
            int age = ageSpinner.Value ?? 0;

            MessageBox.Show($"{firstName} {lastName}, you are {age}. Gender: {gender}");
        }

        private void GenderCheck(object sender, RoutedEventArgs e)
        {
            RadioButton? radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.IsChecked == true) {
                gender = radioButton.Content.ToString()!;
            }
        }
    }
}