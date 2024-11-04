using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropdownBind.Models;

namespace DropdownBind.Controllers
{
    public class CasController : Controller
    {
        masterEntities _context = new masterEntities();
        // GET: Cas
        public ActionResult Index()
        {
            ViewBag.Statelist = new SelectList(GetStateList(), "StateID", "StateName");
            return View();
        }

        public ActionResult GetCityList(int StateID)
        {
            List<City_Master> CityList = _context.City_Master.Where(x => x.StateID == StateID).ToList();
            ViewBag.CityList = new SelectList(CityList, "CityID", "CityName");
            return PartialView("DisplayCity");

        }

        public List<State_Master> GetStateList()
        {
            List<State_Master> StateList = _context.State_Master.ToList();
            return StateList;
        }
    }
}