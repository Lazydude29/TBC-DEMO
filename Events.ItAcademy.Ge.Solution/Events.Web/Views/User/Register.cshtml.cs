using Events.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Web.Pages
{
    public class RegisterModel : PageModel
    {
        public RegisterViewModel Model { get; set; }

        public RegisterModel()
        {
            //_userManager = userManager;
            //_signInManager = signInManager;
        }

        public void OnGet()
        {
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new IdentityUser()
        //        {
        //            UserName = Model.Email,
        //            Email = Model.Email
        //        };

        //        var result = await _userManager.CreateAsync(user, Model.Password);

        //        if (result.Succeeded)
        //        {
        //            await _signInManager.SignInAsync(user, false);
        //            return RedirectToPage("Index");
        //        }

        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //    }

        //    return Page();
        //}
    }
}
