using Microsoft.AspNetCore.Mvc;
using netMvcApp.EFCoreExamples;
using netMvcApp.Models;

namespace netMvcApp.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context = new AppDbContext();


        [ActionName("Index")]
        public IActionResult BlogIndex()
        {
            List<BlogModel> lst = _context.Blog.ToList();
            return View("BlogIndex", lst);
        }
    }
}