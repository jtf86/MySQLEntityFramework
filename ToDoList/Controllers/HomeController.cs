﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private ToDoListContext db = new ToDoListContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Tasks.ToList());
        }
    }
}
