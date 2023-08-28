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
    /// Interaction logic for Admin_Tasks.xaml
    /// </summary>
    public partial class Admin_Tasks : Page
    {
        public Admin_Tasks(Book book = null)
        {
            InitializeComponent();
            bookIdTbx.IsEnabled = false;
            SetTextBoxValues(book);
            purchaseDateDpc.DisplayDateEnd = DateTime.Now;
        }

        public void SetTextBoxValues(Book book)
        {
            if(book != null)
            {
                bookIdTbx.Text = book.BookId.ToString();
                nameTbx.Text = book.Name;
                authorTbx.Text = book.Author;
                publisherTbx.Text = book.Publisher;
                genreTbx.Text = book.Genre;
                priceTbx.Text = book.Price.ToString();
                purchaseDateDpc.Text = book.PurchaseDate.ToString();
                quantityTbx.Text = book.TotalQuantity.ToString();

                addBookBtn.IsEnabled = false;
            }

        }

        public Book GetTextBoxValues()
        {
            Book book = new Book();
            book.BookId = int.Parse(bookIdTbx.Text);
            book.Name = nameTbx.Text;
            book.Author = authorTbx.Text;
            book.Publisher = publisherTbx.Text;
            book.Genre = genreTbx.Text;
            book.Price = decimal.Parse(priceTbx.Text);
            book.PurchaseDate = DateTime.Parse(purchaseDateDpc.Text);
            book.TotalQuantity = int.Parse(quantityTbx.Text);

            return book;
        }



        private async void ProcessBook(string operationType)
        {
            Book bookToEdit = GetTextBoxValues();
            string uri = $"/Book/{operationType}Book";
            HttpResponseMessage response = new HttpResponseMessage();
            if (operationType == "Add")
            {
                response = await Processor.InformationPost<Book>(uri, bookToEdit);
            }
            else if (operationType == "Edit")
            {
                response = await Processor.InformationPut<Book>(uri, bookToEdit);
            }
            else if (operationType == "Delete")
            {
                uri += $"/{bookToEdit.BookId}";
                response = await Processor.InformationDelete(uri);
            }

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Book has been {operationType.ToLower()}ed successfully");
            }
        }

        private void addBookBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessBook("Add");
        }
        private void editBookBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessBook("Edit");
        }

        private void deleteBookBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessBook("Delete");
        }

        //private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        //{
        //    _passValue = (int)e.ExtraData;

        //    MessageBox.Show(_passValue.ToString());
        //    bookIdTbx.Text = _passValue.ToString();
        //}

        //private void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.LoadCompleted += NavigationService_LoadCompleted;
        //}
    }
}
