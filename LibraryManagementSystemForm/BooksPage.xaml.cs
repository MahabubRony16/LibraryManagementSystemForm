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
        public Books()
        {
            InitializeComponent();
            LoadBooks_Get();
            _selectedBook = new Book();
        }

        public async void LoadBooks_Get()
        {
            IEnumerable<Book> bookList = await Processor.InformationGet<IEnumerable<Book>>("/Book/GetBooks/0/None/None/None/None");
            booksCvw.ItemsSource = bookList;
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
    }
}
