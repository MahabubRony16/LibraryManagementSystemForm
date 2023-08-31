using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HelperClasses.Models;

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

        public void addGoogleBookToDb(GoogleBook book)
        {
            MapperConfiguration mapperConfig = new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<Item, GoogleBook>()
                .ForMember(destination => destination.Title, options =>
                options.MapFrom(source => source.volumeInfo.title))
                .ForMember(destination => destination.Subtitle, options =>
                options.MapFrom(source => source.volumeInfo.subtitle))
                .ForMember(destination => destination.AuthorOne, options =>
                options.MapFrom(source => source.volumeInfo.authors[0]))
                .ForMember(destination => destination.AuthorTwo, options =>
                options.MapFrom(source => source.volumeInfo.authors[1]))
                .ForMember(destination => destination.AuthorThree, options =>
                options.MapFrom(source => source.volumeInfo.authors[2]))
                .ForMember(destination => destination.AuthorFour, options =>
                options.MapFrom(source => source.volumeInfo.authors[3]))
                .ForMember(destination => destination.AuthorFive, options =>
                options.MapFrom(source => source.volumeInfo.authors[4]))
                .ForMember(destination => destination.Publisher, options =>
                options.MapFrom(source => source.volumeInfo.publisher))
                .ForMember(destination => destination.PublishedDate, options =>
                options.MapFrom(source => source.volumeInfo.publishedDate))
                .ForMember(destination => destination.Description, options =>
                options.MapFrom(source => source.volumeInfo.description))
                .ForMember(destination => destination.BookPageCount, options =>
                options.MapFrom(source => source.volumeInfo.pageCount))
                .ForMember(destination => destination.SmallThumbnail, options =>
                options.MapFrom(source => source.volumeInfo.imageLinks.smallThumbnail))
                .ForMember(destination => destination.Thumbnail, options =>
                options.MapFrom(source => source.volumeInfo.imageLinks.thumbnail))
                .ForMember(destination => destination.Language, options =>
                options.MapFrom(source => source.volumeInfo.language))
                .ForMember(destination => destination.DownloadLink, options =>
                options.MapFrom(source => source.accessInfo.epub.downloadLink));

            });
        }

    }
}
