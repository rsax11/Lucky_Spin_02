using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuckySpin;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lucky_Spin_02
{
    public class SpinnerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return new ContentResult {Content = new Lucky7().Output(), ContentType = "text/html"};
        }
    }
}
