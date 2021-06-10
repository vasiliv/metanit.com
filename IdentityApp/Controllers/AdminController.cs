using IdentityApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Controllers
{
    public class AdminController : Controller
    {
        //ApplicationDbContext _context;
        //public AdminController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        //public IActionResult Index()
        //{
        //    var users = _context.Users.ToList();
        //    return View(users);
        //}
        UserManager<IdentityUser> _userManager;
        public AdminController(UserManager<IdentityUser> manager)
        {
            _userManager = manager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
    }
}
