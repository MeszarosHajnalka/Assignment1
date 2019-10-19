using System;

namespace Assignment1
{
    public class Book
    {
        private string title;
        private string author;
        private int pageNumber;
        private string isbn13;

        public Book(string title, string author, int pageNumber, string isbn13)
        {
            SetTitle(title);
            this.author = author;
            SetPageNumber(pageNumber);
            SetIsbn13(isbn13);
        }

        public string Title { get => title; set => SetTitle(value); }
        public string Author { get => author; set => author = value; }
        public int PageNumber { get => pageNumber; set => SetPageNumber(value); }
        public string Isbn13 { get => isbn13; set => SetIsbn13(value); }

        private void SetTitle(string title)
        {
            if (title.Length>=2)
            {
                this.title = title;
            }
            else
            {
                throw new ArgumentException("Title must be at least two characters long");
            }
        }

        private void SetPageNumber(int pageNo)
        {
            if (pageNo > 10 && pageNo <= 1000)
            {
                this.pageNumber = pageNo;
            }
            else
            {
                throw new ArgumentException("Pagenumber must be between 10 and 1000");
            }
        }

        private void SetIsbn13 (string isbn)
        {
            if (isbn.Length == 13)
            {
                this.isbn13 = isbn;
            }
            else
            {
               throw new ArgumentException("Isbn13 must have exactly 13 characters");
            }
        }
    }
}
