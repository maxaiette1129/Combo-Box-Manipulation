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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

            InitializeComponent();
            UserCMB();
        }


        private void UserCMB()
        {

            userAuturityList.Items.Add("Select Authority List");
            userAuturityList.SelectedIndex = 0;
            userAuturityList.Items.Add("Guest");
            userAuturityList.Items.Add("Student");
            userAuturityList.Items.Add("Admin");
            userAuturityList.Items.Add("Teacher");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (userAuturityList.SelectedIndex == 0) MessageBox.Show("Selecting User authority required!");
            else
            { MessageBox.Show($"You have Selected {userAuturityList.Text}" +
                $"\nLevel of {userAuturityList.SelectedIndex}");
              
            }
        }
    }
}
