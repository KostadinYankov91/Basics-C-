namespace BookShop
{
    using BookShop.Data;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

           
            string result = CountCopiesByAuthor(db);
            Console.WriteLine(result);
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();

            AgeRestriction ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            string[] bookTitles = context
                .Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            foreach (string title in bookTitles)
            {
                sb.AppendLine(title);
            }

            return sb.ToString().TrimEnd();
            
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            string[] goldenBooks = context
                .Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            foreach (string title in goldenBooks)
            {
                sb.AppendLine(title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();

            string[] booksNotReleasedIn = context
                .Books
                .Where(b => b.ReleaseDate.HasValue &&
                            b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            foreach (string title in booksNotReleasedIn)
            {
                sb.AppendLine(title);
            }

            return sb.ToString().TrimEnd();

        }

        //public static string GetBooksByCategory(BookShopContext context, string input)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    string[] splittedInput = input.Split().ToArray();

        //    string[] bookTitlesByCategory = context
        //        .Books
        //        .Where(b => b.Title == splittedInput[0] ||
        //                    b.Title == splittedInput[1] ||
        //                    b.Title == splittedInput[2])
        //        .
                
        //}

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            string[] authorNames = context
                .Authors
                .ToArray()
                .Where(a => a.FirstName.EndsWith(input.ToLower()))
                .Select(a => $"{a.FirstName} {a.LastName}")
                .OrderBy(n => n)
                .ToArray();

            foreach (string name in authorNames)
            {
                sb.AppendLine(name);
            }

            return sb.ToString().TrimEnd();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var totalBookCopies = context
                .Authors
                .Include(c => c.Books)
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName,
                    TotalBookCopies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.TotalBookCopies)
                .ToArray();

            foreach (var total in totalBookCopies)
            {
                sb.AppendLine($"{total.FullName} - {total.TotalBookCopies}");
            }

            return sb.ToString().TrimEnd();
                
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categoriesByProfit = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    TotalProfit = c.CategoryBooks
                    .Sum(cb => cb.Book.Copies * cb.Book.Price)
                })
                .OrderByDescending(b => b.TotalProfit)
                .ThenBy(c => c.CategoryName)
                .ToArray();

            foreach (var category in categoriesByProfit)
            {
                sb.AppendLine($"{category.CategoryName} ${category.TotalProfit:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categoriesWithMostRecentBooks = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    MostRecentBooks = c.CategoryBooks
                    .Select(cb => cb.Book)
                    .OrderByDescending(b => b.ReleaseDate)
                    .Select(cb => new
                    {
                        BookTitle = cb.Title,
                        ReleaseYear = cb.ReleaseDate.Value.Year
                    })
                    .Take(3)
                    .ToArray()
                })
                .OrderBy(c => c.CategoryName)
                .ToArray();


            foreach (var recent in categoriesWithMostRecentBooks)
            {
                sb.AppendLine($"--{recent.CategoryName}");
                foreach (var book in recent.MostRecentBooks)
                {
                    sb.AppendLine($"{book.BookTitle} {book.ReleaseYear}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
