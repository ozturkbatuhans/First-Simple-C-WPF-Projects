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

namespace dagvandeweek
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
            int iDagNummer = int.Parse(txtDagNummer.Text);

            lblResult.Content = ((iDagNummer == 1) ? "Maandag" :
                                 (iDagNummer == 2) ? "Dinsdag" :
                                  (iDagNummer == 3) ? "Woensdag" :
                                   (iDagNummer == 4) ? "Donderdag" :
                                    (iDagNummer == 5) ? "Vrijdag" :
                                     (iDagNummer == 6) ? "Zaterdag" :
                                      (iDagNummer == 7) ? "Zondag" : "ongeldig input");
        }
    }
}