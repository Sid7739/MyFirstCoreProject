using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMvc_CoreApplicant.Models;
using FirstMvc_CoreApplicant.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvc_CoreApplicant.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository =null;

        public BookController( )
        {
            _bookRepository = new BookRepository();
        }

        public List<BookModel> GetAllBook()
        {
            return _bookRepository.GetAllBook();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string name,string author)
        {
            return _bookRepository.SearchBook(name, author);
        }
    }
}
