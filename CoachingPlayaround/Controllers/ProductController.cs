using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoachingPlayaround.Controllers
{
    public class ProductController : Controller
    {
        public List<Item> Items = new List<Item>()
        {
            new Item {ID = 1, Price = 10, Name = "Bear", Description = "Salmon"},
            new Item {ID = 2, Price = 12, Name = "Tiger", Description = "Stripes"},
            new Item {ID = 3, Price = 14, Name = "Lion", Description = "Scary"}
        };
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.items = Items;
            return View();
        }

        public ActionResult Details(int ID)
        {
            //call the Db and grab me and item with id == ID

            //return that item to the view
            Item selectedItem = null;

            foreach (var item in Items)
            {
                if (item.ID == ID)
                {
                    selectedItem = item;
                    break;
                }
                selectedItem = null;
            }

            ViewBag.item = selectedItem;

            return View();
        }

    }
}