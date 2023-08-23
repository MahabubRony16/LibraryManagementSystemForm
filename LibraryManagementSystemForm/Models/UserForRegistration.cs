using System;

namespace LibraryManagementSystemForm.Models
{
    public partial class UserForRegistration
    {
        public string FirstName {get; set;} = String.Empty;
        public string LastName {get; set;} = String.Empty;
        public string Email {get; set;} = String.Empty;
        public string Contact {get; set;} = String.Empty;
        public string Address {get; set;} = String.Empty;
        public string Password {get; set;} = String.Empty;
        public string PasswordConfirm {get; set;} = String.Empty;
    }
}