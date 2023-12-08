using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fruitkha_task.Data;
using fruitkha_task.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Data;
using Microsoft.Extensions.Configuration;
using fruitkha_task.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fruitkha_task.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ContactViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var contact = new Contact
            {
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                Subject = model.Subject,
                Message = model.Message
            };

            _dbContext.Contact.Add(contact);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}

