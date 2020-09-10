using FirstMvc_CoreApplicant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvc_CoreApplicant.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBook()
        {
            return BookDataSource();
        }
        public BookModel GetBookById(int id)
        {
            return BookDataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string name,string author)
        {
            return BookDataSource().Where(x=>x.Name.Contains(name) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> BookDataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Name="Love",Author="sidhant"},
                new BookModel(){Id=2,Name="Love Ajkal",Author="Sravani"},
                new BookModel(){Id=3,Name="MVC",Author="Rabindra"},
                new BookModel(){Id=4,Name="Banda",Author="sidhant"},
                new BookModel(){Id=4,Name="Hello",Author="sidhant Das"},
            };
        }
    }
}
