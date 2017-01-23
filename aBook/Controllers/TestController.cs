using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoaBook;

namespace aBook.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        PostFac pf = new PostFac();

        public ActionResult Index()
        {

            return View(pf.GetAll());
        }
    }
}