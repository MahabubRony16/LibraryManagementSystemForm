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
using System.Windows.Shapes;

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            string searchCriteria = searchCategoryCbx.SelectedItem.ToString();

            SearchCriteriaBook searchBook = new SearchCriteriaBook();
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
}
