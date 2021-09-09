using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneProject.Models;
using CapstoneProject.Repository;
using Microsoft.AspNetCore.Identity;
using CapstoneProject.Data;

namespace CapstoneProject.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private IAccountRepository _accRepo;

        public RaceContext _dbContext;

        public AccountController(IAccountRepository accRepo, RaceContext dbContext)
        {
            _accRepo = accRepo;
            _dbContext = dbContext;
        }

        [Route("signup")]
        public IActionResult Signup()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> Signup(SignUpUserModel signupuser)
        {
            // registration of the user
            if (ModelState.IsValid)
            {
                var result = await _accRepo.CreateUser(signupuser);
                foreach(var errorMsg in result.Errors)
                {
                    ModelState.AddModelError("", errorMsg.Description);
                    return View(signupuser);
                }
                ModelState.Clear();
                return RedirectToAction(actionName: "login");
            }
            return View(signupuser);
        }

        [Route("login")]
        public IActionResult login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> login(LogInModel loginUser)
        {
            if (ModelState.IsValid)
            {
                var result = await _accRepo.SigInUserAsync(loginUser);
                if (!result.Succeeded) { 
                    ModelState.AddModelError("", "Invalid Credentials");
                    return View(loginUser);
                }
                ModelState.Clear();
                return RedirectToAction(actionName: "index", controllerName:"Home");
            }
            return View(loginUser);
        }

        [Route("logout")]
        public IActionResult logout()
        {
            _accRepo.LogOutUserAsync();
            return RedirectToAction("index", "Home");
        }

        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
           return View("~/Views/Account/AccessDenied.cshtml");
        }

    }
}
