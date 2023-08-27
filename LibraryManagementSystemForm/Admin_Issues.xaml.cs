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
using System.Xml.Linq;

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for Admin_Issues.xaml
    /// </summary>
    public partial class Admin_Issues : Page
    {
        private int _pageNo;
        public Admin_Issues()
        {
            InitializeComponent();
            _pageNo = 1;
            LoadIssues_Get(1, 50);
        }
        public async void LoadIssues_Get(int page = 0, int itemsPerPage = 0)
        {
            string searchString = CreateSearchString(searchTbx);
            string uri = $"/Issue/GetIssues/{page}/{itemsPerPage}/{searchString}";
            IEnumerable<Issue> issueList = await Processor.InformationGet<IEnumerable<Issue>>(uri);
            AllIssues.ItemsSource = issueList;

            pageNoTbl.Text = "Page " + _pageNo.ToString();
        }

        public string CreateSearchString(TextBox txtBox = null)
        {
            string searchCriteria = ((ComboBoxItem)searchCategoryCbx.SelectedItem).Content.ToString();

            int issueId = 0;
            int bookId = 0;
            int userId = 0;

            if (txtBox != null)
            {
                TextBox searchTbx = txtBox;
                if (!string.IsNullOrWhiteSpace(searchTbx.Text))
                {
                    if (searchCriteria == "Issue ID")
                    {
                        issueId = Int32.Parse(searchTbx.Text);
                    }
                    else if (searchCriteria == "Book ID")
                    {
                        bookId = Int32.Parse(searchTbx.Text);
                    }
                    else if (searchCriteria == "User ID")
                    {
                        userId = Int32.Parse(searchTbx.Text);
                    }
                }
            }
            return $"{issueId}/{bookId}/{userId}";
        }

        private void searchBookBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo = 1;
            LoadIssues_Get(1, 50);
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
                LoadIssues_Get(_pageNo, 50);

            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo++;
            LoadIssues_Get(_pageNo, 50);

            prevBtn.IsEnabled = true;
        }
    }
}
