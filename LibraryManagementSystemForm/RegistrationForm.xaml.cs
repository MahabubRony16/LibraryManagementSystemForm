using HelperClasses;
using LibraryManagementSystemForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for RegistrationForm.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        public RegistrationForm()
        {
            InitializeComponent();
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

            HttpResponseMessage response = await Processor.InformationPost<UserForRegistration>("/Auth/Register", userForRegistration);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("User Created!!");
            }
        }
    }
}
