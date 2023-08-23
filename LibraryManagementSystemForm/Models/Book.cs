using System;

namespace LibraryManagementSystemForm.Models
{
    public class Book
    {
        public int BookId {get; set;}
        public string Name {get; set;} = String.Empty;
        public string Author {get; set;} = String.Empty;
        public string Publisher {get; set;} = String.Empty;
        public decimal Price {get; set;}
        public string Genre {get; set;} = String.Empty;
        public DateTime PurchaseDate {get; set;}
        public int TotalQuantity {get; set;}
        public int AvailableQuantity {get; set;}

    }
}