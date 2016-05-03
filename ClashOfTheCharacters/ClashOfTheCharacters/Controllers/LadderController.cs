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
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Ladder
        public ActionResult Index()
        {
            //Om det finns n�gon str�ng i s�kbaren s�k, annars visa alla anv�ndare,
            string userSearch = Request["SearchInput"] == null ? "" : Request["SearchInput"];
            var users = context.Users.Where(c => c.UserName.ToLower().Contains(userSearch.ToLower())).OrderByDescending(c => c.LadderPoints).ToList();
            return View(users);
        }
    }
}