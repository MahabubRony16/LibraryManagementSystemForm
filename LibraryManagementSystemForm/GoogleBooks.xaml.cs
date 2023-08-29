using HelperClasses;
using LibraryManagementSystemForm.Models;
using LibraryManagementSystemForm.Models.GoogleBooks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        private Dictionary<string, string> _fields;
        public GoogleBooks()
        {
            InitializeComponent();
            InitializeInfos();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            string parameterUri = CreateParametersUri();
            RunApi(parameterUri);
        }

        private async void RunApi(string uri)
        {
            MessageBox.Show(uri);
            searchParameterUriTbx.Text = uri;
            try
            {
                //GoogleBookMetadata googleBook = await Processor.GoogleInformationGet<GoogleBookMetadata>(uri);
                GoogleBook googleBook = await Processor.GoogleInformationGet<GoogleBook>(uri);
                MessageBox.Show(googleBook.totalItems.ToString());
                //IEnumerable<Item> volumes = googleBook.items;
                //WriteToJsonFile(googleBook);
                //booksCvw.ItemsSource = volumes;
            }
            catch
            {
                MessageBox.Show("Could not run api");
            }
            
            
        }
        private void WriteToJsonFile<T>(T model)
        {
            string file = "C:\\Users\\HP\\Downloads\\GoogleBookInfo.json";
            string json = JsonConvert.SerializeObject(model);
            File.WriteAllText(file, json);
        }

        private void InitializeInfos()
        {
            _fields = new Dictionary<string, string>()
            {
                { "Title", "intitle" },
                { "Author", "inauthor" },
                { "Publisher", "inpublisher" },
                { "Subject", "insubject" }
            };

            searchFieldsCbx.ItemsSource = new List<string>(_fields.Keys);
        }
        private string CreateParametersUri()
        {
            string urlParameters = String.Empty;
            urlParameters += "?q=";
            urlParameters += _fields[searchFieldsCbx.SelectedItem.ToString()];
            urlParameters += ":";
            urlParameters += searchStringTbx.Text.Replace(" ", "+");
            //urlParameters += "&maxResults=" + maxResultsSdr.Value;

            return urlParameters;
        }

    }
}
