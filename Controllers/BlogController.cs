using Microsoft.AspNetCore.Mvc;
using netMvcApp.EFCoreExamples;
using netMvcApp.Models;

namespace netMvcApp.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context = new AppDbContext();

        // http://localhost:7021/Blog/index
        [ActionName("Index")]
        public IActionResult BlogIndex()
        {
            List<BlogModel> lst = _context.Blog.ToList();
            return View("BlogIndex", lst);
        }

        //http://localhost:7021/Blog/Edit/1
        [ActionName("Edit")]

        public IActionResult BlogEdit(int id)
        {
            var item = _context.Blog.FirstOrDefault(ea => ea.Blog_Id == id);
            if (item == null)
            {
                return Redirect("/Blog");
            }
            return View("BlogEdit", item);
        }

        [ActionName("Create")]
        public IActionResult BlogCreate()
        {
            return View("BlogCreate");
        }

        [HttpPost]
        [ActionName("Save")]
        public IActionResult BlogSave(BlogModel blog)
        {
            _context.Blog.Add(blog);
            _context.SaveChanges();

            return Redirect("/Blog");
        }

        [HttpPost]
        [ActionName("Update")]
        public IActionResult BlogUpdate(int id, BlogModel blog)
        {

            var item = _context.Blog.FirstOrDefault(ea => ea.Blog_Id == id);



            item.Blog_Title = blog.Blog_Title;
            item.Blog_Author = blog.Blog_Author;
            item.Blog_Content = blog.Blog_Content;

            _context.SaveChanges();
            return Redirect("/Blog");
        }


        [ActionName("Delete")]
        public IActionResult BlogDelete(int id)
        {

            var item = _context.Blog.FirstOrDefault(ea => ea.Blog_Id == id);
            if (item == null)
            {
                return Redirect("/Blog");
            }
            _context.Blog.Remove(item);
            _context.SaveChanges();
            return Redirect("/Blog");

        }


    }
}