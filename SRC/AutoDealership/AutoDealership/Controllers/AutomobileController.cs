using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoDealership.Models;

namespace AutoDealership.Controllers
{
    public class AutomobileController : Controller
    {
        // GET: Automobile
        public ActionResult Index()
        {
            var automobiles = from a in GetAutomobileList()
                              orderby a.ID
                              select a;
            return View(automobiles);
        }

        // GET: Automobile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Automobile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automobile/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Automobile/Edit/5
        public ActionResult Edit(int id)
        {
            List<Automobile> automobileList = GetAutomobileList();
            var automobile = automobileList.Single(m => m.ID == id);
            return View(automobile);
            
        }

        // POST: Automobile/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var automobile = automobileList.Single(m => m.ID == id);
                if (TryUpdateModel(automobile))
                {
                    //To Do:- database code
                    return RedirectToAction("Index");
                }
                return View(automobile);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Automobile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Automobile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [NonAction]
        public List<Automobile> GetAutomobileList()
        {
            return new List<Automobile>
            {
                new Automobile
                {
                    ID = 1,
                    Make = "Chevrolet",
                    Model = "Corvette",
                    Year = 2017,
                    Color = "Silver"
            },

                new Automobile
                {
                    ID = 2,
                    Make = "Cadillac",
                    Model = "Escalade",
                    Year = 2017,
                    Color = "Black",
                },

                new Automobile
                {
                    ID = 3,
                    Make = "BMW",
                    Model = "BMW X6",
                    Year = 2017,
                    Color = "White",
                },

                new Automobile
                {
                    ID = 4,
                    Make = "Ferrari",
                    Model = "Ferrari 458 Coupe",
                    Year = 2017,
                    Color = "Purple Haze",
                },
             };
         }

        public static List<Automobile> automobileList = new List<Automobile>
        {
           
   
         new Automobile
                {
                    ID = 1,
                    Make = "Chevrolet",
                    Model = "Corvette",
                    Year = 2017,
                    Color = "Silver"
            },

                new Automobile
                {
                    ID = 2,
                    Make = "Cadillac",
                    Model = "Escalade",
                    Year = 2017,
                    Color = "Black",
                },

                new Automobile
                {
                    ID = 3,
                    Make = "BMW",
                    Model = "BMW X6",
                    Year = 2017,
                    Color = "White",
                },

                new Automobile
                {
                    ID = 4,
                    Make = "Ferrari",
                    Model = "Ferrari 458 Coupe",
                    Year = 2017,
                    Color = "Purple Haze",
                },
             };
         }

}
}


