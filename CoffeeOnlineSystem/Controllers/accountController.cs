using CoffeeOnlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeOnlineSystem.Controllers
{
    public class accountController : Controller
    {
        // GET: customer
        public ActionResult Index(string strSearch)
        {
            customertList stu = new customertList();
            List<account> obj = stu.getCustomer(null);
            if (!string.IsNullOrEmpty(strSearch))
            {
                obj = obj.Where(x => x.Fullname.Contains(strSearch)).ToList();
            }
            ViewBag.StrSearch = strSearch;
            return View(obj);
        }
    }
}