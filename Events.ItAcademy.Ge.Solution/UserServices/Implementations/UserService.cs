using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserServices.Interfaces;

namespace UserServices.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;


        public UserService()
        {

        }

        public Task<bool> TryRegisterAsync()
        {
            var user = new IdentityUser()
            {
                UserName = Model.Email,
                Email = Model.Email
            };

            var result = await _userManager.CreateAsync(user, Model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return RedirectToPage("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
