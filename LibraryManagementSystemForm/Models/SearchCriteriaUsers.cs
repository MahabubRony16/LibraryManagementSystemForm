using System;

namespace LibraryManagementSystemForm.Models
{
    public class SearchCriteriaBook
    {
        public int BookId { get; set; } = 0;
        public string Name {get; set;} = "None";
        public string Author {get; set;} = "None";
        public string Publisher {get; set;} = "None";
        public string Genre {get; set;} = "None";

    }
}