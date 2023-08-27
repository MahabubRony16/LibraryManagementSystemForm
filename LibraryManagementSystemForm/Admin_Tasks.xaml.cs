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
    /// Interaction logic for Admin_Tasks.xaml
    /// </summary>
    public partial class Admin_Tasks : Page
    {
        public Admin_Tasks(Book book = null)
        {
            InitializeComponent();
            PopuletTextBoxes(book);
            purchaseDateDpc.DisplayDateEnd = DateTime.Now;
        }

        public void PopuletTextBoxes(Book book)
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
            }

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
