using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using TradingView.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace TradingView.Pages
{
    public class SignInModel : PageModel
    {
        [BindProperty]
        public User user { get; set; } 

        private UserContext db;

        public SignInModel(UserContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            user = new User();
        }
        public async Task<IActionResult> OnPost()
        {
            if (db.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password) != null)
            {
                await Authenticate(user.Username);

                return RedirectToPage("index");
            }
            return null;
        }

        private async Task Authenticate(string userName)
        {
            
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


    }
}
