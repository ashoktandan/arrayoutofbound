using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Testmvc.Models;
using Testmvc.Services;

namespace Testmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly PostService _postService;

        public HomeController(PostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public ActionResult Post(Post post)
        {
            if (ModelState.IsValid) {
                _postService.Create(post);
                return Ok("Post submitted successfully.");
            }
            return BadRequest("Error creating Post.");
        }

        [HttpGet]
        public ActionResult<List<Post>> Get()
        {
            return _postService.Get();
        }

        [HttpGet]
        public ActionResult<Post> Post(string postid)
        {
            return View(_postService.Get(postid));
        }

        [HttpGet]
        public void delete(string postid)
        {
             _postService.Remove(postid);
        }

        public IActionResult Index()
        {
            var posts = (_postService.Get() as IEnumerable<Post>).Reverse();
            ViewBag.top5posts = posts.Take(5);
            return View(posts);
        }

        public IActionResult Write()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
