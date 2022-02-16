using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace FinalTask
{
    public class Program
    {
        public static void Main()
        {
            Logic("htdytey", 1780, "34re", "erev");
        }

        public static void Logic (string bookName, int publicDate, string authorFirstName, string authorLastName)  
        {
            List<Books> booksList = new List<Books>
            {
                new Books ("Harry Potter and the Sorcerer's Stone Harry Potter and the Sorcerer's Stone", 1975, new BookAuthor ("Simona", "Rowling")),
                new Books ("The Subtle Art: A Counterintuitive Approach to Living a Good Life", 2016, new BookAuthor( "Mark", "Manson" )),
                new Books ("Jellybeans From Heaven", 1980, new BookAuthor ("Silvia", "Morrison")),
                new Books ("The Four Agreements: A Practical Guide to Personal Freedom", 1988, new BookAuthor ("Janet", "Case")),
                new Books ("A People's History of the United States", 1980, new BookAuthor ("Pally", "Mill")),
                new Books ("Harry Potter", 1989, new BookAuthor ("Joanne", "Rowling")),
                new Books ("The Maid: A Novel", 2001, new BookAuthor ("Nita",  "Prose")),
                new Books ("Real Easy: a bold, mesmerising and unflinching thriller featuring three unforgettable women", 1990, new BookAuthor ("Marie", "Rutkoski")),
                new Books ("Fiona and Jane", 1989, new BookAuthor ("Jean", "Chen Co" )),
                new Books ("Joan Is Okay: A Novel", 1991, new BookAuthor ("Weike", "Wang"))
            };

            booksList.Add( new Books(bookName, publicDate, new BookAuthor(authorFirstName, authorLastName)));



            var selectedList = booksList
            .Where(x => x.PublicDate < 1990)
            .OrderBy(x => x.BookName)
            .ToList();

            foreach (var book in selectedList)
            {
                Console.WriteLine($"'{book.BookName}' was published in {book.PublicDate} year by {book.Author.AuthorFirstName} {book.Author.AuthorLastName}");
            }

            var selectedList1 = booksList
            .Where(x => x.PublicDate < 1990)
            .OrderBy(x => x.Author.AuthorFirstName)
            .ToList();

            foreach (var book in selectedList1)
            {
                Console.WriteLine($"'{book.BookName}' was published in {book.PublicDate} year by {book.Author.AuthorFirstName} {book.Author.AuthorLastName}");
            }
        }
    }
}