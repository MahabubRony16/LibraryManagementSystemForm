using HelperClasses;
using LibraryManagementSystemForm.Models;
using LibraryManagementSystemForm.Models.GoogleBooks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
    /// 
    
    public partial class GoogleBooks : Window
    {
        //private Dictionary<string, string> _fields;
        private bool _advancedSearchOn;
        private Item _selectedBook;
        private string _downloadLink;
        private string _previewLink;

        public GoogleBooks()
        {
            InitializeComponent();
            InitializeInfos();
            _selectedBook = new();
            maxResultsValueTbl.Text = maxResultsSdr.Value.ToString();
            _advancedSearchOn = false;
            downloadPageBtn.Visibility = Visibility.Hidden;
            previewPageBtn.Visibility = Visibility.Hidden;
            _downloadLink = string.Empty;
            _previewLink = string.Empty;
        }

        private async void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(searchStringTbx.Text))
            {
                string parameterUri = CreateParametersUri();
                await RunApi(parameterUri);
                this.Height = 850;
                //this.Height = booksCvw.ActualHeight;
            }
            else
            {
                MessageBox.Show("Nothing to search!");
            }
        }

        private async Task<string> RunApi(string uri)
        {
            try
            {
                GoogleBookMetadata googleBook = await Processor.GoogleInformationGet<GoogleBookMetadata>(uri);
                IEnumerable<Item> volumes = googleBook.items;
                //WriteToJsonFile(googleBook);
                booksCvw.ItemsSource = volumes;
            }
            catch
            {
                MessageBox.Show("Could not run the search");
            }

            return "Done";
        }
        private void WriteToJsonFile<T>(T model)
        {
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                path = Directory.GetParent(path).ToString();
            }
            string file = $"{path}\\Downloads\\GoogleBookInfo.json";
            string json = JsonConvert.SerializeObject(model);
            File.WriteAllText(file, json);
        }

        private void InitializeInfos()
        {
            searchFieldsCbx.ItemsSource = new List<string>(SearchParameters.basicSearchParameters.Keys);
            downloadFormateCbx.ItemsSource = new List<string>(SearchParameters.downloadFormates.Keys);
            filterCbx.ItemsSource = new List<string>(SearchParameters.filters.Keys);
            printTypeCbx.ItemsSource = new List<string>(SearchParameters.printTypes.Keys);
            sortCbx.ItemsSource = new List<string>(SearchParameters.sorting.Keys);
        }
        private string CreateParametersUri()
        {
            string urlParameters = String.Empty;
            urlParameters += "?q=";
            urlParameters += SearchParameters.basicSearchParameters[searchFieldsCbx.SelectedItem.ToString()];
            urlParameters += ":";
            urlParameters += searchStringTbx.Text.Replace(" ", "+");
            urlParameters += "&maxResults=" + maxResultsSdr.Value;
            if(_advancedSearchOn)
            {
                urlParameters += CreateAdvancedParametersUri();
            }
            return urlParameters;
        }

        private string CreateAdvancedParametersUri()
        {
            string urlAdvancedParameters = string.Empty;
            urlAdvancedParameters += "&download=" + SearchParameters.downloadFormates[downloadFormateCbx.SelectedItem.ToString()];
            urlAdvancedParameters += "&filter=" + SearchParameters.filters[filterCbx.SelectedItem.ToString()];
            urlAdvancedParameters += "&printType=" + SearchParameters.printTypes[printTypeCbx.SelectedItem.ToString()];
            urlAdvancedParameters += "&sorting=" + SearchParameters.sorting[sortCbx.SelectedItem.ToString()];

            return urlAdvancedParameters;
        }

        private void SetBookDetails(Item book)
        {
            //MessageBox.Show("Populating details");
            if(!string.IsNullOrWhiteSpace(book?.volumeInfo?.imageLinks?.thumbnail))
            {
                detailImage.Source = new BitmapImage(new Uri(book.volumeInfo.imageLinks.thumbnail, UriKind.RelativeOrAbsolute));
                
            }
            else
            {
                detailImage.Source = new BitmapImage(new Uri(@"C:\Users\HP\Documents\GitHub\LibraryManagementSystemForm\LibraryManagementSystemForm\Assets\No-Image-Placeholder.png", UriKind.RelativeOrAbsolute));
            }

            if (book?.volumeInfo != null)
            {
                titleTbl.Text = book.volumeInfo.title;
                subTitleTbl.Text = book.volumeInfo.subtitle;
                descriptionTbl.Text = book.volumeInfo.description;
                ratingTbl.Text = "Rating: " + book.volumeInfo.averageRating.ToString() + " ( " + book.volumeInfo.ratingsCount.ToString()  + " )";

                string authorsList = string.Empty;
                if (book.volumeInfo.authors != null)
                {
                    foreach (string author in book.volumeInfo.authors)
                    {
                        authorsList += ", " + author;
                    }
                    if (authorsList.StartsWith(","))
                    {
                        authorsList = authorsList[2..];
                    }
                }

                authorTbl.Text = "Author:                   " + authorsList;
                publisherTbl.Text = "Publisher:               " + book.volumeInfo.publisher;
                publishedDateTbl.Text = "Published Date:      " + book.volumeInfo.publishedDate;
                pageCountTbl.Text = "Page count:             " + book.volumeInfo.pageCount.ToString();
                languageTbl.Text = "Language:               " + book.volumeInfo.language;
            }
            
        }


        private void booksCvw_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Width = 1350;
            downloadPageBtn.IsEnabled = false;
            previewPageBtn.IsEnabled = false;
            downloadPageBtn.Visibility = Visibility.Visible;
            previewPageBtn.Visibility = Visibility.Visible;

            Item _selectedBook = (Item)booksCvw.SelectedItem;
            //MessageBox.Show(selectedBook.id);
            if (_selectedBook != null)
            {
                SetBookDetails(_selectedBook);
            }

            if (!string.IsNullOrWhiteSpace(_selectedBook?.accessInfo?.epub?.downloadLink))
            {
                _downloadLink = _selectedBook.accessInfo.epub.downloadLink;
                downloadPageBtn.IsEnabled = true;
            }
            
            if (!string.IsNullOrWhiteSpace(_selectedBook?.volumeInfo?.previewLink))
            {
                _previewLink = _selectedBook?.volumeInfo?.previewLink;
                previewPageBtn.IsEnabled = true;
            }
        }
        private void maxResultsSdr_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (maxResultsValueTbl != null)
            {
                maxResultsValueTbl.Text = maxResultsSdr.Value.ToString();
            }
            
        }

        private void advancedSearchExr_Expanded(object sender, RoutedEventArgs e)
        {
            _advancedSearchOn = true;
        }

        private void advancedSearchExr_Collapsed(object sender, RoutedEventArgs e)
        {
            _advancedSearchOn = false;
        }

        private void downloadPageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_downloadLink))
            {
                var sInfo = new System.Diagnostics.ProcessStartInfo(_downloadLink)
                {
                    UseShellExecute = true,
                };
                System.Diagnostics.Process.Start(sInfo);
            }

        }

        private void previewPageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_previewLink))
            {
                var sInfo = new System.Diagnostics.ProcessStartInfo(_previewLink)
                {
                    UseShellExecute = true,
                };
                System.Diagnostics.Process.Start(sInfo);
            }
        }
    }
}
