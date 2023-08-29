using HelperClasses;
using LibraryManagementSystemForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interaction logic for Books.xaml
    /// </summary>
    public partial class Books : Page
    {
        private Book _selectedBook;
        private int _pageNo;
        public Books()
        {
            InitializeComponent();
            LoadBooks_Get(1, 10);
            _selectedBook = new Book();
            _pageNo = 1;
            prevBtn.IsEnabled = false;
        }

        public async void LoadBooks_Get(int page = 0, int itemsPerPage = 0)
        {
            string searchString = CreateSearchString(searchTbx);
            string uri = $"/Book/GetBooks/{page}/{itemsPerPage}/{searchString}";
            IEnumerable<Book> bookList = await Processor.InformationGet<IEnumerable<Book>>(uri);
            booksCvw.ItemsSource = bookList;
            pageNoTbl.Text = "Page " + _pageNo.ToString();
        }
        public async void CreateIssue_Post()
        {
            Issue issueToPost = new Issue()
            {
                BookId = _selectedBook.BookId,
                UserId = 1015,
                IssueDate = DateTime.UtcNow.Date,
                ReturnDate = DateTime.UtcNow.Date.AddDays(7)
            };
            HttpResponseMessage result = await Processor.InformationPost<Issue>("/Issue/AddIssue", issueToPost);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Issue Created!!");
            }

        }

        public async void DeleteIssue_Delete()
        {
            HttpResponseMessage result = await Processor.InformationDelete("/Issue/DeleteIssue/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Issue Deleted!!");
            }
        }

        private void booksCvw_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _selectedBook = (Book)booksCvw.SelectedItem;
            detailNameTbl.Text = _selectedBook.Name;
            detailAuthorTbl.Text = _selectedBook.Author;
            detailPublisherTbl.Text = "Publisher: " + _selectedBook.Publisher;
            detailGenreTbl.Text = "Genre: " + _selectedBook.Genre;
        }

        private void issueBookBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateIssue_Post();
        }

        private void returnBookBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            if(_pageNo > 1)
            {
                if (_pageNo == 2)
                {
                    prevBtn.IsEnabled = false;
                }
                _pageNo--;
                LoadBooks_Get(_pageNo, 10);
                
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo++;
            LoadBooks_Get(_pageNo, 10);
           
            prevBtn.IsEnabled = true;
        }

        private void searchBookBtn_Click(object sender, RoutedEventArgs e)
        {
            _pageNo = 1;
            LoadBooks_Get(1, 10);
            
        }

        public string CreateSearchString(TextBox txtBox = null)
        {
            string searchCriteria = ((ComboBoxItem)searchCategoryCbx.SelectedItem).Content.ToString();

            SearchCriteriaBook searchBook = new SearchCriteriaBook();

            if (txtBox != null)
            {
                TextBox searcTbx = txtBox;
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
        
    }
}
