using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperClasses
{
    public class Reusable
    {
        private Dictionary<string, string> _searchSubcategories;
        private Dictionary<string, string> _searchStringStartings;
        public Reusable()
        {
            _searchSubcategories = new Dictionary<string, string>();
            _searchStringStartings = new Dictionary<string, string>()
            {
                { "Books", "Book/GetBooks"},
                { "Users", "User/GetUsers"},
                { "Issues", "Issue/GetIssues"}
            };
        }

        public string CreateSearchString(string mainCategoryName, string searchSubcategoryName, string searchBoxContent, int page = 0, int itemsPerPage = 0)
        {
            _searchSubcategories = SetSearchSubcategories(mainCategoryName);
            string searchString = $"{_searchStringStartings[mainCategoryName]}/{page}/{itemsPerPage}";

            if (!string.IsNullOrWhiteSpace(searchBoxContent))
            {
                _searchSubcategories[searchSubcategoryName] = searchBoxContent;
            }

            foreach (var item in _searchSubcategories)
            {
                searchString += $"/{item.Value}";
            }

            return searchString;
        }

        public Dictionary<string, string> SetSearchSubcategories(string mainCategoryName)
        {
            if (mainCategoryName == "Books")
            {
                return new Dictionary<string, string>()
                {
                    { "Book ID", "0"},
                    { "Title", "None"},
                    { "Author", "None"},
                    { "Publisher", "None"},
                    { "Genre", "None"}
                };
            }
            else if (mainCategoryName == "Users")
            {
                return new Dictionary<string, string>()
                {
                    { "User ID", "0"},
                    { "Name", "None"}
                };
            }
            else if (mainCategoryName == "Issues")
            {
                return new Dictionary<string, string>()
                {
                    { "Issue ID", "0"},
                    { "Book ID", "0"},
                    { "User ID", "0"}
                };
            }

            return new Dictionary<string, string>();

        }

    }
}
