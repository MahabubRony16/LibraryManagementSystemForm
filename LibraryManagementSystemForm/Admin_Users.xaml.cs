using HelperClasses;
using LibraryManagementSystemForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for Admin_Users.xaml
    /// </summary>
    public partial class Admin_Users : Page
    {
        public Admin_Users(User user = null)
        {
            InitializeComponent();
            userIdTbx.IsEnabled = false;
            emailTbx.IsEnabled = false;
            SetTextBoxValues(user);
        }

        public void SetTextBoxValues(User user)
        {
            if (user != null)
            {
                userIdTbx.Text = user.UserId.ToString();
                firstNameTbx.Text = user.FirstName;
                lastNameTbx.Text = user.LastName;
                emailTbx.Text = user.Email;
                contactTbx.Text = user.Contact;
                addressTbx.Text = user.Address;
                ageTbx.Text = user.Age.ToString();
                userTypeCbx.SelectedIndex = userTypeCbx.Items.IndexOf(user.UserType);
                //userTypeCbx = ((ComboBoxItem)userTypeCbx.SelectedItem).Content.ToString();
            }

        }

        public User GetTextBoxValues()
        {
            User user = new User();
            user.UserId = int.Parse(userIdTbx.Text);
            user.FirstName = firstNameTbx.Text;
            user.LastName = lastNameTbx.Text;
            user.Email = emailTbx.Text;
            user.Contact = contactTbx.Text;
            user.Address = addressTbx.Text;
            user.Age = int.Parse(ageTbx.Text);
            user.UserType = ((ComboBoxItem)userTypeCbx.SelectedItem).Content.ToString(); ;
            return user;
        }

        private async void ProcessUser(string operationType)
        {
            User user = GetTextBoxValues();
            string uri = $"/User/{operationType}User";
            HttpResponseMessage response = new HttpResponseMessage();
            if (operationType == "Add")
            {
                response = await Processor.InformationPost<User>(uri, user);
            }
            else if (operationType == "Edit")
            {
                response = await Processor.InformationPut<User>(uri, user);
            }
            else if (operationType == "Delete")
            {
                uri += $"/{user.UserId}";
                response = await Processor.InformationDelete(uri);
            }

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"User has been {operationType.ToLower()}ed successfully");
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessUser("Edit");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessUser("Delete");
        }

    }
}
