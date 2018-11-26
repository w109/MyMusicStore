using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            //return View("../../Views/Test/test1");
            return View();
        }

        public string Welcome(string name,int id=1)
        {
            return "您好,"+name+",欢迎次数："+id;
        }
    }
}