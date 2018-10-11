using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniPhoneBook.Models;

namespace MiniPhoneBook.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            Entities db = new Entities();
            List<Person> list = db.People.ToList();
            List<PERSON> viewlist = new List<PERSON>();
            foreach(Person p in list)
            {
                PERSON obj = new PERSON();
                obj.FirstName = p.FirstName;
                obj.FirstName = p.FirstName;
                obj.LastName = p.LastName;
                obj.MiddleName = p.MiddleName;

                

                //ob  j.DateOfBirth = p.DateOfBirth;
               // obj.AddedOn = p.AddOn;
                obj.AddedBy = p.AddedBy;
                obj.HomeAddress = p.HomeAddress;
                obj.HomeCity = p.HomeCity;
                obj.FaceBookAccount = p.FaceBookAccount;
                obj.LinkedInId = p.LinkedInId;
                //obj.UpdatedOn = p.UpdateOn;
                obj.TwitterId = p.TwitterId;
                obj.EmailId = p.EmailId;

                viewlist.Add(obj);

            }
            return View(viewlist);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        //FormCollection collection
        public ActionResult Create(PERSON obj) 
        {
            try
            {
                // TODO: Add insert logic here
                Person p = new Person();
                p.FirstName = obj.FirstName;
                p.LastName = obj.LastName;
                p.MiddleName = obj.MiddleName;
                p.DateOfBirth = obj.DateOfBirth;
                p.AddOn = obj.AddedOn;
                p.AddedBy = obj.AddedBy;
                p.HomeAddress = obj.HomeAddress;
                p.HomeCity = obj.HomeCity;
                p.FaceBookAccount = obj.FaceBookAccount;
                p.LinkedInId = obj.LinkedInId;
                p.UpdateOn = obj.UpdatedOn;
                p.TwitterId = obj.TwitterId;
                p.EmailId = obj.EmailId;
                
                Entities db = new Entities();
                
                db.People.Add(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
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
    }
}
