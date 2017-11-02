using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_OpenIDConnect_DotNet.Controllers
{
    public class TodoAppController : Controller
    {
        // GET: TodoApp
        public ActionResult Index()
        {
            return View();
        }
    }
}