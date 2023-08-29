﻿using HelperClasses;
using LibraryManagementSystemForm.Models;
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

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for AdminAreaPage.xaml
    /// </summary>
    public partial class AdminAreaPage : Page
    {
        public AdminAreaPage()
        {
            InitializeComponent();
        }

        private void showTablesBtn_Click(object sender, RoutedEventArgs e)
        {
            adminFrm.Content = new Admin_Tables();
        }

        private void addBooksBtn_Click(object sender, RoutedEventArgs e)
        {
            adminFrm.Content = new Admin_Tasks();
        }

        private void showIssuesBtn_Click(object sender, RoutedEventArgs e)
        {
            adminFrm.Content = new Admin_Issues();
        }

        private void showUsersBtn_Click(object sender, RoutedEventArgs e)
        {
            adminFrm.Content = new Admin_Users();
        }
    }
}
