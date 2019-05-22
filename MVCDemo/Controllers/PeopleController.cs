using System;
using System.Collections.Generic;
using MVCDemo.Models;   
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> People = new List<PersonModel>();

            People.Add(new PersonModel { FirstName = "Godwin", LastName = "Otokina", Age = 205 });
            People.Add(new PersonModel { FirstName = "Win Code", LastName = "Otokina", Age = 205 });
            People.Add(new PersonModel { FirstName = "Win", LastName = "Otokina", Age = 205 });

            return View(People);
        }
    }
}