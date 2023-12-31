﻿using LibraryManagementSystemForm.Models;
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
using System.Windows.Shapes;

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto()
            {
                Email = loginEmailTbx.Text,
                Password = loginPasswordTbx.Password.ToString()
            };
        }
    }
}
