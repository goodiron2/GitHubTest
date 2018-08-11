using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubTest.Models
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var test = 1;
            return View();
        }
    }
}