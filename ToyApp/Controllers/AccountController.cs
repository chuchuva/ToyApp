﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ToyApp.Models;

namespace ToyApp.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
            : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
        {
        }

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<ApplicationUser> UserManager { get; private set; }

        [Route("account/signup")]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [Route("account/signup")]
        public async Task<ActionResult> Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    FullName = model.FullName,
                    UserName = model.Email,
                    Email = model.Email
                };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return Json(result);
                }
                else
                {
                    foreach (var error in result.Errors)
                        ModelState.AddModelError("", error);

                }
            }
            // Something is wrong, redisplay the page
            return View();
        }
	}
}
