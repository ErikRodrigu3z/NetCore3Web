using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using NetCore3.Common;
using NetCore3.Models;
using NetCore3.Persistence;

namespace NetCore3.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            Repository<Cutomers> repo = new Repository<Cutomers>(_db);
            
            Cutomers cust = new Cutomers
            {
                Name = "Erik",
                FirstName = "Rodriguez",
                LastName = "Gallegos",
                Address = ".",
                PhoneNumber = "123456789"
            };

            //Add 
            //repo.Add(cust);

            //edit
            //cust.Name = "Antonio";
            //repo.Edit(cust);

            //delete
            //repo.Delete(cust);

            //get 
            //List<Cutomers> list = repo.GetAll().ToList();

            //get by id
            //var model = repo.GetById(1);

            //get by predicate
            //var model2 = repo.GetByPredicate(x => x.Name == "Antonio").ToList();

            //get list form sp
            //SqlParameter[] parametros =
            //{
            //    new SqlParameter("@name", "Antonio")
            //};

            //var model3 = repo.FunctionToList("SpGetCustomers", parametros).ToList();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
