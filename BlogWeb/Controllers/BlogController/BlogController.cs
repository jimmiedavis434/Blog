using BlogWeb.Data;
using BlogWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWeb.Controllers.BlogController
{
    public class BlogController : Controller
    {
        private readonly BlogDbContext _db;
        public BlogController(BlogDbContext db) { _db = db; }

        // Index. homepage with list of ordered blogs by date
        public IActionResult Index()
        {
            IEnumerable<Blog> BlogList = _db.blogs.OrderBy(blog => blog.BlogDate);
            return View(BlogList);
        }

        // Read. blog post details page
        public  IActionResult Read(int? Id, Blog blog)
        {
            
            var blogPost = _db.blogs.Find(Id);
            if(Id == null || Id == 0)
            {
                return NotFound();
            }
            else
            {
                return View(blogPost);
            }
        }
    }
}
