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

namespace Lotto3
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

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            Label1.Content = Label2.Content = Label3.Content = Label4.Content = Label5.Content = Label6.Content = "  ---  ";

            resetBtn.IsEnabled = false;
        }

        private void getBtn_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int[] digits = new int[6] { rand.Next() % 59, rand.Next() % 59, rand.Next() % 59, rand.Next() % 59, rand.Next() % 59, rand.Next() % 59 };

            Label1.Content = digits[0];
            Label2.Content = digits[1];
            Label3.Content = digits[2];
            Label4.Content = digits[3];
            Label5.Content = digits[4];
            Label6.Content = digits[5];

            resetBtn.IsEnabled = true;
        }
    }
}