using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySQL_Sample.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySQL_Sample.Controllers
{
    public class MyTestController : Controller
    {
        public MySQLSampleDbContext DbContext { get; }

        public MyTestController(MySQLSampleDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public IActionResult Index()
        {
            var result = DbContext.MyTests.ToList();
            ViewData["UserList"] = result;

            return View();
        }
    }
}
