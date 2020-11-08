using CoffeeOnlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeOnlineSystem.Controllers
{
    public class productsController : Controller
    {
        // GET: products
        public ActionResult Index(string strSearch)
        {
            productList stu = new productList();
            List<products> obj = stu.getProduct(null);
            if (!string.IsNullOrEmpty(strSearch))
            {
                obj = obj.Where(x => x.NameProduct.Contains(strSearch)).ToList();
            }
            ViewBag.StrSearch = strSearch;
            return View(obj);
        }

        // GET: products/Details/5
        public ActionResult Detail(int id)
        {
            productList stu = new productList();
            List<products> obj = stu.getProduct(id);
            return View(obj.FirstOrDefault());
        }

        // GET: products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: products/Create
        [HttpPost]
        public ActionResult Create(products pro)
        {
            if (ModelState.IsValid)
            {
                productList proList = new productList();
                proList.addProduct(pro);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: products/Edit/5
        public ActionResult Edit(int id)
        {
            productList stu = new productList();
            List<products> obj = stu.getProduct(id);
            return View(obj.FirstOrDefault());//chi laay 1 san pham thoi
        }

        // POST: products/Edit/5
        [HttpPost]
        public ActionResult Edit(products pro)
        {
            if (ModelState.IsValid)
            {
                productList proList = new productList();
                proList.update(pro);
                return RedirectToAction("Index");
            }

            return View();
        }
        // GET: products/Delete/5
        public ActionResult Delete(int id)
        {
            productList proList = new productList();
            proList.delete(id);
            return RedirectToAction("Index");
        }

       
       
    }
}
