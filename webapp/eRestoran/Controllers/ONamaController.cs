using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Data;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.Controllers
{
    public class ONamaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONamaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
