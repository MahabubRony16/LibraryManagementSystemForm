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

        private void registrationBtn_Click(object sender, RoutedEventArgs e)
        {
            new RegistrationForm().Show();
        }

        private void booksPageBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrm.Content = new Books();
        }

        private void loginFormBtn_Click(object sender, RoutedEventArgs e)
        {
            new LoginForm().Show();
        }

        private void adminAreaBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrm.Content = new AdminAreaPage();
        }
    }
}
