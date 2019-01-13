using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using LoginReg.Models;

namespace LoginReg.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(RegViewModel register)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
            
        }
        [HttpPost("login")]
        public IActionResult Login(LogViewModel login)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");

        }
        [HttpGet("success")]
        public string Success()
        {
            return "SUCCESS!";
        }

    }
}
