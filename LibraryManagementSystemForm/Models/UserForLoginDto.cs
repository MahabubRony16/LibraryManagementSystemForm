using System;

namespace LibraryManagementSystemForm.Models
{
    public partial class UserForLoginDto
    {
        public string Email {get; set;} = String.Empty;
        public string Password {get; set;} = String.Empty;
        
    }
}