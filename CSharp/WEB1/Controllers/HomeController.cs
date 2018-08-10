using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB1.Models;

namespace WEB1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ContactModel model = GetData().Contacts;

            return View(model);
        }

        public ActionResult Catalog()
        {
            List<ItemModel> items = GetData().Items;
                return View(items);
        }
        public ActionResult Buy(string name)
        {
            ItemModel item = null;
            foreach(ItemModel m in GetData().Items)
            {
                if(m.Name == name)
                {
                    item = m;
                    break;
                }
            }
            if(Session["preces"] == null)
            {
                Session["preces"] = new List<ItemModel>();
            }
            (Session["preces"] as List<ItemModel>).Add(item);
            return RedirectToAction("Catalog");
        }
        public static ShopModel GetData()
        {
            return new ShopModel()
            {
                Name = "  ",
                Contacts = new ContactModel()
                {
                    EMail = "eng@inbox.lv",
                    Phone = " 2233445 ",
                    Location = new AdressModel()
                    {
                        Country = " Latvija ",
                        City = " Rīga ",
                        Street = "Brīvības  ",
                        HouseNo = " 130 ",
                        ApartmentNo = 3,
                    }

                },
                Items = new List<ItemModel>()
                {
                    new ItemModel()
                    {
                        Name = " Dators",
                        Price = new PriceModel()
                        {
                        Amount = 800,
                        Currency = "$ ",
                        }

                    },
                     new ItemModel()
                    {
                        Name = " TV",
                        Price = new PriceModel()
                        {
                        Amount = 1500,
                        Currency = "$ ",
                        }

                        //nosaukums + cena
                    },
                },
                                
            };
        }
    }
}