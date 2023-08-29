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
using System.Xml.Linq;

namespace LibraryManagementSystemForm
{
    /// <summary>
    /// Interaction logic for Admin_Issues.xaml
    /// </summary>
    public partial class Admin_Issues : Page
    {
        public Admin_Issues(Issue issue = null)
        {
            InitializeComponent();
            SetTextBoxValues(issue);
        }

        public void SetTextBoxValues(Issue issue)
        {
            if (issue != null)
            {
                issueIdTbx.Text = issue.IssueId.ToString();
                bookIdTbx.Text = issue.BookId.ToString();
                userIdTbx.Text = issue.UserId.ToString();
                issueDateDpc.Text = issue.IssueDate.ToString();
                returnDateDpc.Text = issue.ReturnDate.ToString();
                addIssueBtn.IsEnabled = false;
                issueIdTbx.IsEnabled = false;
            }

        }

        public Issue GetTextBoxValues()
        {
            Issue issue = new Issue();
            //issue.IssueId = Int32.Parse(issueIdTbx.Text);
            issue.BookId = Int32.Parse(bookIdTbx.Text);
            issue.UserId = Int32.Parse(userIdTbx.Text);
            MessageBox.Show(issueDateDpc.Text);
            issue.IssueDate = DateTime.Parse(issueDateDpc.Text);
            issue.ReturnDate = DateTime.Parse(returnDateDpc.Text);

            return issue;
        }



        private async void ProcessBook(string operationType)
        {
            Issue issue = GetTextBoxValues();
            string uri = $"/Issue/{operationType}Issue";
            HttpResponseMessage response = new HttpResponseMessage();
            if (operationType == "Add")
            {
                response = await Processor.InformationPost<Issue>(uri, issue);
            }
            else if (operationType == "Edit")
            {
                response = await Processor.InformationPut<Issue>(uri, issue);
            }
            else if (operationType == "Delete")
            {
                uri += $"/{issue.IssueId}";
                response = await Processor.InformationDelete(uri);
            }

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Issue has been {operationType.ToLower()}ed successfully");
            }
        }
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessBook("Add");
        }
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessBook("Edit");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ProcessBook("Delete");
        }
    }
}
