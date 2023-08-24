using HelperClasses;
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
    /// Interaction logic for Admin_Issues.xaml
    /// </summary>
    public partial class Admin_Issues : Page
    {
        public Admin_Issues()
        {
            InitializeComponent();
            LoadIssues_Get();
        }
        public async void LoadIssues_Get()
        {
            IEnumerable<Issue> userList = await Processor.InformationGet<IEnumerable<Issue>>("/Issue/GetIssues/0/0");
            AllIssues.ItemsSource = userList;
        }
    }
}
