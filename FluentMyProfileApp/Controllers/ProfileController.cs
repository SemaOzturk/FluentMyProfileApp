using FluentMyProfileApp.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace FluentMyProfileApp.Controllers;

public class ProfileController : Controller
{


    public IActionResult Edit()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Edit(ProfileVm profile)
    {
      
        if(!ModelState.IsValid)
            return View(profile);
        return View();
    }
}