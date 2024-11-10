using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Model
{
    public class Book
    {
        public int bookİd { get; set; }
        public string bookName { get; set; }
        public string bookWriter { get; set; }
        public string bookLanguage { get; set; }
        public string publisher { get; set; }
        public string bookType { get; set; }
        public int piece { get; set; }
        public int pageCount { get; set; }
        public int publicationYear { get; set; }

        public Book() { }

        public Book(int bookİd, string bookName, string book_writer, string bookLanguage, string publisher, string bookType, int piece, int pageCount, int publicationYear)
        {
            this.bookİd = bookİd;
            this.bookName = bookName;
            this.bookWriter = book_writer;
            this.bookLanguage = bookLanguage;
            this.publisher = publisher;
            this.bookType = bookType;
            this.piece = piece;
            this.pageCount = pageCount;
            this.publicationYear = publicationYear;
        }

        public int getBookİd() { return this.bookİd; }
        public string getBookName() { return this.bookName; }
        public string getBookWriter() { return this.bookWriter; }
        public string getBookLanguage() { return this.bookLanguage; }
        public string getPublisher() { return this.publisher; }
        public string getBookType() { return this.bookType; }
        public int getPiece() { return this.piece; }
        public int getPageCount() { return this.pageCount; }
        public int getPublicationYear() { return this.publicationYear; }
    }
}

