using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using HelperClasses;
using LibraryManagementSystemForm.Models;

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }


        private async void applyBtn_Click(object sender, RoutedEventArgs e)
        {
            UserForRegistration userForRegistration = new UserForRegistration()
            {
                FirstName = firstNameTbx.Text,
                LastName = lastNameTbx.Text,
                Email = emailTbx.Text,
                Contact = contactTbx.Text,
                Address = addressTbx.Text,

                Password = passwordTbx.Text,
                PasswordConfirm = confirmPasswordTbx.Text
            };

            TestConnectionDto userInfo = new TestConnectionDto()
            {
                FirstName = firstNameTbx.Text,
                LastName = lastNameTbx.Text,
                te = 75
            };

            HttpStatusCode statusCode = await Processor.LoadInformationPost<UserForRegistration>("/Auth/Register", userForRegistration);
            Console.WriteLine(statusCode.ToString());

        }
    }
}
