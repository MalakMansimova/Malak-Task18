using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_04
{
    internal class Book
    {
        public Book(string title)
        {
            PageCount++;
            Id = PageCount;
            Title = title;
            SetCode();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public static int PageCount { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }
        public void SetCode()
        {
            Code = Title[0] + "-" + Id;
        }

    }
}
