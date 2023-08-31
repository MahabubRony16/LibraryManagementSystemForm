using System;

namespace LibraryManagementSystemForm.Models
{
    public class GoogleBook
    { 
        public int BookId {get; set;}
        public string Title {get; set;} = String.Empty;
        public string Subtitle {get; set;} = String.Empty;
        public string AuthorOne {get; set;} = String.Empty;
        public string AuthorTwo {get; set;} = String.Empty;
        public string AuthorThree {get; set;} = String.Empty;
        public string AuthorFour {get; set;} = String.Empty;
        public string AuthorFive {get; set;} = String.Empty;
        public string Publisher {get; set;} = String.Empty;
        public DateTime PublishedDate {get; set;}
        public string Description {get; set;} = String.Empty;
        public int BookPageCount {get; set;}
        public string SmallThumbnail {get; set;} = String.Empty;
        public string Thumbnail {get; set;} = String.Empty;
        public string Language {get; set;} = String.Empty;
        public string DownloadLink {get; set;} = String.Empty;

    }
}