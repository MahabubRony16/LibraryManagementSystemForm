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
    /// Interaction logic for Admin_Users.xaml
    /// </summary>
    public partial class Admin_Users : Page
    {
        private int _pageNo;
        public Admin_Users()
        {
            InitializeComponent();
            _pageNo = 1;
            LoadUsers_Get(1, 50);
        }
        public async void LoadUsers_Get(int page = 0, int itemsPerPage = 0)
        {
            string searchString = CreateSearchString(searchTbx);
            string uri = $"/User/GetUsers/{page}/{itemsPerPage}/{searchString}";
            IEnumerable<User> userList = await Processor.InformationGet<IEnumerable<User>>(uri);
            AllUsers.ItemsSource = userList;

            pageNoTbl.Text = "Page " + _pageNo.ToString();
        }

        public string CreateSearchString(TextBox txtBox = null)
        {
            string searchCriteria = ((ComboBoxItem)searchCategoryCbx.SelectedItem).Content.ToString();

            int userId = 0;
            string name = "None";

            if (txtBox != null)
            {
                TextBox searchTbx = txtBox;
                if (!string.IsNullOrWhiteSpace(searchTbx.Text))
                {
                    if (searchCriteria == "User ID")
                    {
                        userId = Int32.Parse(searchTbx.Text);
                    }
                    else if (searchCriteria == "Name")
                    {
                        name = searchTbx.Text;
                    }
                }
            }
            return $"{userId}/{name}";
        }

        private void searchBookBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo = 1;
            LoadUsers_Get(1, 50);

        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_pageNo > 1)
            {
                if (_pageNo == 2)
                {
                    prevBtn.IsEnabled = false;
                }
                _pageNo--;
                LoadUsers_Get(_pageNo, 50);

            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo++;
            LoadUsers_Get(_pageNo, 50);

            prevBtn.IsEnabled = true;
        }
    }
}
