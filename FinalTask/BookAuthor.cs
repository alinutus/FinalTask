using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace FinalTask
{
    public class BookAuthor
    {
		string _authorFirstName;
		public string AuthorFirstName

		{ get => _authorFirstName;
		  set
			{
				if (value == string.Empty || value.Length > 256)
				{
					throw new Exception();
				}
				_authorFirstName = value;
			}
		}

		string _authorLastName;

		public string AuthorLastName

		{
			get => _authorLastName;
			set
			{
				if (value == string.Empty || value.Length > 256)
				{
					throw new Exception();
				}
				_authorLastName = value;
			}
		}

		public BookAuthor(string authorFirstName, string authorLastName)
		{
			AuthorFirstName = authorFirstName;
			AuthorLastName = authorLastName;
		}

        public BookAuthor()
        {
        }
    }
}
