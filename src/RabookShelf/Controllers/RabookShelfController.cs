﻿using RabookShelf.Data;
using RabookShelf.Models;
using System.Web.Mvc;

namespace RabookShelf.Controllers
{
    public class RabookShelfController : Controller
    {
        private Context context = new Context();

        //Get Index
        public ActionResult Index()
        {
            var books = Repository.GetBooks();
            return View(books);
        }

        //Add
        public ActionResult Add()
        {
            return View("Add");
        }

        //Add
        [HttpPost]
        public ActionResult Add(string title, string firstName, string lastName, 
                                bool? fiction, BookSize booksize, string description)
        {
            return View("Add");
        }


        //Edit

        //Delete

        //Get Entry
        public ActionResult Entry()
        {
            return View("Entry");
        }

    }
}