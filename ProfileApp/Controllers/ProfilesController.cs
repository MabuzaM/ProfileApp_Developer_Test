using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProfileApp.Models;

namespace ProfileApp.Controllers
{

    public class ProfilesController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ProfilesController(ApplicationDBContext db)
        {
            _db = db;
        }


        [BindProperty]
        public Profile Profile{ get; set; }
        public IActionResult Index()
        {
            var displaydata = _db.Profiles.ToList();
            return View(displaydata);
        }



        #region API Calls

        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Profiles.ToListAsync() });
        }

        public async Task<IActionResult> Profilespage(int id)
        {
            var profileFromDB = await _db.Profiles.FirstOrDefaultAsync(u => u.Id == id);
            if (profileFromDB == null)
            {
                return Json(new { success = false, message = "Error Viewing Profile" });
            }
            return View(profileFromDB);

        }
        #endregion
    }
}
