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
    /// Interaction logic for Admin_Tables.xaml
    /// </summary>
    public partial class Admin_Tables : Page
    {
        private Dictionary<string, string> _searchSubcategories;
        private Dictionary<string, string> _searchStringStarting;
        private int _pageNo;
        private int _itemsPerPageForAdmin;
        private string _mainCategoryName;
        private string _searchSubcategoryName;
        
        public Admin_Tables()
        {
            InitializeComponent();

            InitializeDictionarys();
            _pageNo = 1;
            _itemsPerPageForAdmin = 50;
            SetSubcategories();
        }
        private void InitializeDictionarys()
        {
            _searchStringStarting = new Dictionary<string, string>()
            {
                { "Books", "Book/GetBooks"},
                { "Users", "User/GetUsers"},
                { "Issues", "Issue/GetIssues"}
            };
        }
        private Dictionary<string, string> SetSearchSubcategories(string mainCategoryName) 
        {
            if(mainCategoryName == "Books")
            {
                return new Dictionary<string, string>()
                {
                    { "Book ID", "0"},
                    { "Title", "None"},
                    { "Author", "None"},
                    { "Publisher", "None"},
                    { "Genre", "None"}
                };
            }
            else if (mainCategoryName == "Users")
            {
                return new Dictionary<string, string>()
                {
                    { "User ID", "0"},
                    { "Name", "None"}
                };
            }
            else if (mainCategoryName == "Issues")
            {
                return new Dictionary<string, string>()
                {
                    { "Issue ID", "0"},
                    { "Book ID", "0"},
                    { "User ID", "0"}
                };
            }

            return new Dictionary<string, string>();

        }

        public string CreateSearchString(string mainCategoryName, string searchSubcategoryName, string searchBoxContent, int page = 0, int itemsPerPage = 0)
        {
            _searchSubcategories = SetSearchSubcategories(mainCategoryName);
            string searchString = $"{_searchStringStarting[_mainCategoryName]}/{page}/{itemsPerPage}";

            if (!string.IsNullOrWhiteSpace(searchBoxContent))
            {
                _searchSubcategories[searchSubcategoryName] = searchBoxContent;
            }  
            
            foreach (var item in _searchSubcategories)
            {
                searchString += $"/{item.Value}";
            }

            return searchString;
        }

        public async void GetContentFromApiToTable<T>(int page = 0, int itemsPerPage = 0)
        {
            string uri = CreateSearchString(_mainCategoryName, _searchSubcategoryName, searchTbx.Text, page, itemsPerPage);
            //MessageBox.Show(uri);
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
            _searchSubcategories = SetSearchSubcategories(_mainCategoryName);
            List<string> subcategories = new List<string>(_searchSubcategories.Keys);
            searchCategoryCbx.ItemsSource = subcategories;
            searchCategoryCbx.SelectedIndex = 0;
            _searchSubcategoryName = searchCategoryCbx.SelectedItem.ToString();
            LoadContentToTable(1, _itemsPerPageForAdmin);
        }

        private void tableContentTypeCbx_DropDownClosed(object sender, EventArgs e)
        {
            SetSubcategories();
        }

        private void searchCategoryCbx_DropDownClosed(object sender, EventArgs e)
        {
            _searchSubcategories = SetSearchSubcategories(_mainCategoryName);
            _searchSubcategoryName = searchCategoryCbx.SelectedItem.ToString();
        }

        private async void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            var selected = (Book)contentTableDgr.SelectedItem;
            int bookId = selected.BookId;

            string uri = CreateSearchString("Books", "Book ID", bookId.ToString(), 1, 1);
            IEnumerable<Book> contents = await Processor.InformationGet<IEnumerable<Book>>(uri);
            Book bookToEdit = contents.FirstOrDefault();
            if (bookToEdit != null) 
            {
                Admin_Tasks adminFrm = new Admin_Tasks(bookToEdit);
                NavigationService.Navigate(adminFrm);
            }


        }

    }

    


}
