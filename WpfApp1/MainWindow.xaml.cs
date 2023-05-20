using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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


        public class CostumeNumber
        {
            public string countDisplay = "First Number";
            public int countValue = 10;
        }

        public void InitCustumCountValue()
        {
            List<CostumeNumber> lstCostumeNumber = new List<CostumeNumber>();
            CostumeNumber Display = new CostumeNumber();


            Display.countDisplay = "New Display";
            Display.countValue = 50;

            lstCostumeNumber.Add(Display);

            CostumeNumber Display2 = new CostumeNumber
            {
                countValue = 100,
                countDisplay = "2nd Display",

            };
            lstCostumeNumber.Add(Display2 );

            lstCostumeNumber.Add(new CostumeNumber { countDisplay = "3rd Display", countValue = 150 });

            
           
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
           var selectedValue = userAuturityList.SelectedItem.ToString();
            int autorityLevel = 0;
            int autoritySecurity = 0;

            

            switch (selectedValue) 
            {
                case "Guest":
                    autorityLevel = -1;
                    autoritySecurity = 0;
                   
                    break;
                case "Student":
                    autorityLevel = 2 ;
                    autoritySecurity = 1;
                   
                    break;
                case "Admin":
                    autorityLevel = 3;
                    autoritySecurity = 5;
                 
                    break;
                case "Teacher":
                    autorityLevel = 6;
                    autoritySecurity = 9;
                   
                    break;
                default :
                    MessageBox.Show("No Item Selected");
                    break;
            }

            if(userAuturityList.SelectedIndex >= 1) 
            {
                string isSelected = $"The item selected is {selectedValue}" +
                                           $"\n Autority Level is {autorityLevel}" +
                                           $"\n and the security level is {autoritySecurity}";
                MessageBox.Show(isSelected);
            }

        }
    }
}
