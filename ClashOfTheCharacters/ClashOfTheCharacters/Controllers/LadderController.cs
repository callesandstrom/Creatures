using ClashOfTheCharacters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClashOfTheCharacters.Controllers
{
    public class LadderController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Ladder
        public ActionResult Index()
        {
            //Om det finns n�gon str�ng i s�kbaren s�k, annars visa alla anv�ndare,
            if (string.IsNullOrEmpty(Request["SearchInput"] ))
            {
                ViewBag.Search = false;

                return View(db.Users.OrderByDescending(u => u.LadderPoints).ToList());
            }

            else
            {
                var userSearch = Request["SearchInput"];

                ViewBag.Search = true;

                return View(db.Users.Where(c => c.UserName.ToLower().Contains(userSearch.ToLower())).OrderByDescending(c => c.LadderPoints).ToList());
            }
        }
    }
}