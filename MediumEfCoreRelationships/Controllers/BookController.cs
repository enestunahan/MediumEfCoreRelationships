using MediumEfCoreRelationships.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediumEfCoreRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _db;
        public BookController(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult> GetBooks()
        {
            return Ok(await _db.Set<Book>().AsNoTracking().ToListAsync());
        }

        [HttpGet("[action]")]
        public ActionResult GetBooksWithAuthor()
        {
            return Ok ( _db.Set<Book>().AsNoTracking().Include(x=>x.Author).ToList());
        }

        [HttpGet("[action]")]
        public ActionResult GetBooksWithCategories()
        {
            return Ok( _db.Set<Book>().AsNoTracking().Include(x=>x.BookCategories).ThenInclude(z=>z.Category).ToList());
        }

        [HttpGet("[action]")]
        public ActionResult GetBooksWithDetail()
        {
            return Ok(_db.Set<Book>().AsNoTracking().Include(x => x.BookDetail).ToList());
        }

        [HttpGet("[action]/{bookId}")]
        public ActionResult GetBookWithAuthorByBookId(int bookId)
        {
            return Ok( _db.Set<Book>().AsNoTracking().Where(x=>x.Id == bookId).Include(x=>x.Author).SingleOrDefault());
        }
        
        [HttpGet("[action]/{bookId}")]
        public ActionResult GetBookWithCategoryByBookId(int bookId)
        {
            return Ok( _db.Set<Book>().AsNoTracking().Where(x=>x.Id == bookId).Include(x=>x.BookCategories).ThenInclude(x=>x.Category).SingleOrDefault());
        }

        [HttpGet("[action]/{bookId}")]
        public ActionResult GetBookWithDetailByBookId(int bookId)
        {
            return Ok( _db.Set<Book>().AsNoTracking().Where(x=>x.Id == bookId).Include(x=>x.BookDetail).SingleOrDefault());
        }

        [HttpGet("[action]/{bookId}")]
        public ActionResult GetBookWithDetailAndAuthorAndCategoriesByBookId(int bookId)
        {
            return Ok( _db.Set<Book>().AsNoTracking().Where(x=>x.Id == bookId).Include(x=>x.Author).Include(x=>x.BookDetail).Include(x=>x.BookCategories).ThenInclude(x=>x.Category).ToList());
        }
    }
}
