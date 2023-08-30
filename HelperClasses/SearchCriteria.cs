using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperClasses
{
    
    public static class  SearchParameters
    {
        public static Dictionary<string, string> basicSearchParameters = new()
        {
            { "Title", "intitle" },
            { "Author", "inauthor" },
            { "Publisher", "inpublisher" },
            { "Subject", "insubject" }
        };

        public static readonly Dictionary<string, string> downloadFormates = new Dictionary<string, string>()
        {
            {"Epub", "epub" }
        };

        public static readonly Dictionary<string, string> filters = new Dictionary<string, string>()
        {
            {"Partial", "partial" },
            {"Full", "full" },
            {"Free Ebooks", "free-ebooks" },
            {"Paid Ebooks", "paid-ebooks" },
            {"Ebooks", "ebooks" },
        };

        public static readonly Dictionary<string, string> printTypes = new Dictionary<string, string>()
        {
            {"All", "all" },
            {"Books", "books" },
            {"Magazines", "magazines" },
        };

        public static readonly Dictionary<string, string> sorting = new Dictionary<string, string>()
        {
            {"Relevance", "relevence" },
            {"Newest", "newest" }
        };

    }
}
