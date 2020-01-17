/* ***Group 2***
    Amreinder Kaur
    DharaNarola
    Guanlin Li
    Sean Bowery
 */
using System.Windows;

namespace PersonalData
{
    public partial class MainWindow : Window
    {
        VM vm;
        public MainWindow()
        {
            InitializeComponent();
           DataContext = vm;
            
        }
        private void group_Checked(object sender, RoutedEventArgs e)
        {
            vm = new VM("Group");
            DataContext = vm;
        }
        private void firend_Checked(object sender, RoutedEventArgs e)
        {
            vm = new VM("Friends");
            DataContext = vm;
        }
    }
}
