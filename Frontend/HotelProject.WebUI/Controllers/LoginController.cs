﻿using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Staff");
            }
            else
            {
                ModelState.AddModelError("", "Username or password is incorrect");
                return View();
            }
            return View();
        }
    }
}
