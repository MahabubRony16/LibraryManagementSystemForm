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
    /// Interaction logic for Admin_Books.xaml
    /// </summary>
    public partial class Admin_Books : Page
    {
        private int _pageNo;
        public Admin_Books()
        {
            InitializeComponent();
            LoadBooks_Get(1, 50);
            _pageNo = 1;
            LoadBooks_Get(_pageNo, 50);
        }


        public async void LoadBooks_Get(int page = 0, int itemsPerPage = 0)
        {
            string searchString = CreateSearchString(searchTbx);
            string uri = $"/Book/GetBooks/{page}/{itemsPerPage}/{searchString}";
            IEnumerable<Book> bookList = await Processor.InformationGet<IEnumerable<Book>>(uri);
            allBooks.ItemsSource = bookList;
            pageNoTbl.Text = "Page " + _pageNo.ToString();
        }
        private void searchBookBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo = 1;
            LoadBooks_Get(1, 50);

        }
        public string CreateSearchString(TextBox txtBox = null)
        {
            string searchCriteria = ((ComboBoxItem)searchCategoryCbx.SelectedItem).Content.ToString();

            SearchCriteriaBook searchBook = new SearchCriteriaBook();

            if (txtBox != null)
            {
                TextBox searchTbx = txtBox;
                if (!string.IsNullOrWhiteSpace(searchTbx.Text))
                {
                    if (searchCriteria == "Title")
                    {
                        searchBook.Name = searchTbx.Text;
                    }
                    else if (searchCriteria == "Author")
                    {
                        searchBook.Author = searchTbx.Text;
                    }
                    else if (searchCriteria == "Publisher")
                    {
                        searchBook.Publisher = searchTbx.Text;
                    }
                    else if (searchCriteria == "Genre")
                    {
                        searchBook.Genre = searchTbx.Text;
                    }
                }
            }
            return $"{searchBook.BookId}/{searchBook.Name}/{searchBook.Author}/{searchBook.Publisher}/{searchBook.Genre}";
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
                LoadBooks_Get(_pageNo, 50);

            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo++;
            LoadBooks_Get(_pageNo, 50);

            prevBtn.IsEnabled = true;
        }
    }
}
