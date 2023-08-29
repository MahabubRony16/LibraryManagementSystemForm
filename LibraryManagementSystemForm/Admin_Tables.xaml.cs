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
    /// Interaction logic for Admin_Tables.xaml
    /// </summary>
    public partial class Admin_Tables : Page
    {
        private Dictionary<string, string> _searchSubcategories;
        private int _pageNo;
        private int _itemsPerPageForAdmin;
        private string _mainCategoryName;
        private string _searchSubcategoryName;
        private Reusable _reusable;
        public Admin_Tables()
        {
            InitializeComponent();
            _reusable = new Reusable();
            _pageNo = 1;
            _itemsPerPageForAdmin = 50;
            SetSubcategories();
        }

        public async void GetContentFromApiToTable<T>(int page = 0, int itemsPerPage = 0)
        {
            string uri = _reusable.CreateSearchString(_mainCategoryName, _searchSubcategoryName, searchTbx.Text, page, itemsPerPage);
            MessageBox.Show(uri);
            IEnumerable<T> contents = await Processor.InformationGet<IEnumerable<T>>(uri);
            contentTableDgr.ItemsSource = contents;
        }
        private void LoadContentToTable(int page = 0, int itemsPerPage = 0)
        {
            if (_mainCategoryName == "Books")
            {
                GetContentFromApiToTable<Book>(page, itemsPerPage);
            }
            else if (_mainCategoryName == "Users")
            {
                GetContentFromApiToTable<User>(page, itemsPerPage);
            }
            else if (_mainCategoryName == "Issues")
            {
                GetContentFromApiToTable<Issue>(page, itemsPerPage);
            }
            pageNoTbl.Text = "Page " + _pageNo.ToString();
        }
        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadContentToTable(1, _itemsPerPageForAdmin);
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
                LoadContentToTable(_pageNo, _itemsPerPageForAdmin);

            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo++;
            LoadContentToTable(_pageNo, _itemsPerPageForAdmin);

            prevBtn.IsEnabled = true;
        }



        private void SetSubcategories()
        {
            _mainCategoryName = ((ComboBoxItem)tableContentTypeCbx.SelectedItem).Content.ToString();
            _searchSubcategories = _reusable.SetSearchSubcategories(_mainCategoryName);
            List<string> subcategories = new List<string>(_searchSubcategories.Keys);
            searchCategoryCbx.ItemsSource = subcategories;
            searchCategoryCbx.SelectedIndex = 0;
            _searchSubcategoryName = searchCategoryCbx.SelectedItem.ToString();
            LoadContentToTable(1, _itemsPerPageForAdmin);
        }

        private void tableContentTypeCbx_DropDownClosed(object sender, EventArgs e)
        {
            searchTbx.Text = String.Empty;
            SetSubcategories();
        }

        private void searchCategoryCbx_DropDownClosed(object sender, EventArgs e)
        {
            _searchSubcategories = _reusable.SetSearchSubcategories(_mainCategoryName);
            _searchSubcategoryName = searchCategoryCbx.SelectedItem.ToString();
        }

        private async void editItemMenu_Click(object sender, RoutedEventArgs e)
        {
            
            

            if(_mainCategoryName == "Books")
            {
                var selected = (Book)contentTableDgr.SelectedItem;
                int bookId = selected.BookId;
                string uri = _reusable.CreateSearchString("Books", "Book ID", bookId.ToString(), 1, 1);
                IEnumerable<Book> contents = await Processor.InformationGet<IEnumerable<Book>>(uri);
                Book bookToEdit = contents.FirstOrDefault();
                if (bookToEdit != null) 
                {
                    Admin_Tasks adminFrm = new Admin_Tasks(bookToEdit);
                    NavigationService.Navigate(adminFrm);
                }
            }
            else if (_mainCategoryName == "Users")
            {
                var selected = (User)contentTableDgr.SelectedItem;
                int userId = selected.UserId;
                string uri = _reusable.CreateSearchString("Users", "User ID", userId.ToString(), 1, 1);
                IEnumerable<User> contents = await Processor.InformationGet<IEnumerable<User>>(uri);
                User userToEdit = contents.FirstOrDefault();
                if (userToEdit != null)
                {
                    Admin_Users adminFrm = new Admin_Users(userToEdit);
                    NavigationService.Navigate(adminFrm);
                }
            }
            else if (_mainCategoryName == "Issues")
            {
                var selected = (Issue)contentTableDgr.SelectedItem;
                int issueId = selected.IssueId;
                string uri = _reusable.CreateSearchString("Issues", "Issue ID", issueId.ToString(), 1, 1);
                IEnumerable<Issue> contents = await Processor.InformationGet<IEnumerable<Issue>>(uri);
                Issue issueToEdit = contents.FirstOrDefault();
                if (issueToEdit != null)
                {
                    Admin_Issues adminFrm = new Admin_Issues(issueToEdit);
                    NavigationService.Navigate(adminFrm);
                }
            }


        }

        private void deleteItemMenu_Click(object sender, RoutedEventArgs e)
        {
            DeleteItem();
            LoadContentToTable(_pageNo, _itemsPerPageForAdmin);
        }
        private async void DeleteItem()
        {
            string uri = String.Empty;
            if (_mainCategoryName == "Books")
            {
                var selected = (Book)contentTableDgr.SelectedItem;
                int Id = selected.BookId;
                uri = $"/Book/DeleteBook/{Id}";
            }
            else if (_mainCategoryName == "Users")
            {
                var selected = (User)contentTableDgr.SelectedItem;
                int Id = selected.UserId;
                uri = $"/User/DeleteUser/{Id}";
            }
            else if (_mainCategoryName == "Issues")
            {
                var selected = (Issue)contentTableDgr.SelectedItem;
                int Id = selected.IssueId;
                uri = $"/Issue/DeleteIssue/{Id}";
            }

            HttpResponseMessage response = await Processor.InformationDelete(uri);
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deleted successfully");
            }
        }
    }

    


}
