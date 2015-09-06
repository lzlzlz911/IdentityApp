namespace IdentityWebApp
{

    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class ApplicationUser : IdentityUser{

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        private string DisplayAddress{
            get{
                string dspAddress = String.IsNullOrWhiteSpace(Address) ? "" : Address;
                string dspCity = string.IsNullOrWhiteSpace(City) ? "" : Address;
                string dspState = string.IsNullOrWhiteSpace(State) ? "" : State;
                string dspPostalCode = string.IsNullOrWhiteSpace(PostalCode) ? "" : PostalCode;
                return string.Format("{0} {1} {2} {3}", dspAddress, dspCity, dspState, dspPostalCode);
            }
        }

        private async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager){
            ClaimsIdentity userIdentity =
                await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }

    }

}