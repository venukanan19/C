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

namespace Day1_Activity2_WPF
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

        private void btn_displayinfo_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = txt_firstname.Text;
            string LastName = txt_lastname.Text;
            string favcolor = txt_favcolor.Text;

            string userbio = $"user bio :  { FirstName } {LastName} {favcolor}";

            txtblock_display.Text = userbio;
        }
    }
}