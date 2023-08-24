using System;

namespace LibraryManagementSystemForm.Models

{
    public class Issue
    {
        public int IssueId {get; set;}
        public int BookId {get; set;}
        public int UserId {get; set;}
        public DateTime IssueDate {get; set;}
        public DateTime ReturnDate {get; set;}
        


    }
}