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
using System.Windows.Shapes;

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for GoogleBooks.xaml
    /// </summary>
    public partial class GoogleBooks : Window
    {
        public GoogleBooks()
        {
            InitializeComponent();
        }

        private async void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            RunApi();
        }

        private async void RunApi()
        {
            GoogleBook book = await Processor.GoogleInformationGet<GoogleBook>(searchStringTbx.Text);
            MessageBox.Show(book.totalItems.ToString());
        }

    }
}
