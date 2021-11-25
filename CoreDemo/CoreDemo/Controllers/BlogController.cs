using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {

        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index(string s)
        {

            var value = bm.GetBlogListWithCategory();
            return View(value);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var value = bm.GetBlogById(id);
            return View(value);

        }
        public IActionResult BlogListByWriter()
        {
            var value = bm.GetBlogListByWriter(1);
            return View(value);
        }

    }
}
