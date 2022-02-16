using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace FinalTask
{
	public class Books
	{
		string _bookName;
		public string BookName 
		{ 
			get => _bookName;
			set
			{
				if (value == string.Empty || value.Length > 256)
				{
					throw new Exception();
				}
				_bookName = value;
			}
		}

		public int PublicDate { get; set; }

		public BookAuthor Author { get; set; }

		public Books(string bookName, int publicDate, BookAuthor author)
		{
			BookName = bookName;
			PublicDate = publicDate;
			Author = author;
		}

        public Books()
        {
        }
    }
}
