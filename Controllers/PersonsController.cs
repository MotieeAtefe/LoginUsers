using LoginUsers.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginUsers.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Persons person)
        {
            if (ModelState.IsValid)
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.InsertPerson(person.Id, person.FirstName, person.LastName); 
                return RedirectToAction("Index");
            }
            return View(person);
        }
    }
}