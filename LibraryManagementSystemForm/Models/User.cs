using System;

namespace LibraryManagementSystemForm.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string FirstName {get; set;} = String.Empty;
        public string LastName {get; set;} = String.Empty;
        public string Email {get; set;} = String.Empty;
        public string Contact {get; set;} = String.Empty;
        public string Address {get; set;} = String.Empty;
        public int Age {get; set;}
        public string UserType {get; set;} = String.Empty;


    }
}