namespace IdentityWebApp.Controllers{

    using System.Threading.Tasks;
    using System.Web.Mvc;

    using IdentityWebApp.Models;

    using Microsoft.AspNet.Identity;

    public class AccountController : Controller{

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model){
            if (ModelState.IsValid){
                var user = new ApplicationUser{ UserName = model.Email, Email = model.Email };
                user.Address = model.Address;
                user.City = model.City;
                user.State = model.State;
                user.PostalCode = model.PostalCode;

//                var result = new UserManager<ApplicationUser>(.CreateAsync(user, model.Password);
            }
        }

    }

}