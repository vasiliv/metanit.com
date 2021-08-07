using IdentityApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext _context;
        UserManager<IdentityUser> _userManager;
        RoleManager<IdentityRole> _roleManager;
        public AdminController(/*UserManager<IdentityUser> manager,*/ ApplicationDbContext context, RoleManager<IdentityRole> manager)
        {
            //_userManager = manager;
            _context = context;
            _roleManager = manager;
        }        
        //public IActionResult Index()
        //{
        //    var users = _context.Users.ToList();
        //    return View(users);
        //}         
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
        public async Task<IActionResult> GetRoles()
        {
            //_context.Add(new IdentityRole("simpleUser"));
            //await _context.SaveChangesAsync();
            //return View(await _context.Roles.ToListAsync());
            await _roleManager.CreateAsync(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
            return View(await _roleManager.Roles.ToListAsync());
        }
    }
}
