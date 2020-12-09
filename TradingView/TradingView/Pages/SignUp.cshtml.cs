using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TradingView.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace TradingView.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        private UserContext db;

        [BindProperty]
        public string ConfirmPassword { get; set; }

        public SignUpModel(UserContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            user = new User();
        }
        public async Task<IActionResult> OnPost()
        {
            string pattern = @"([\S-\.]+)@";
            if(Regex.IsMatch(user.Email, pattern))
            {
                if (db.Users.FirstOrDefault(u => u.Email == user.Email && u.Username == user.Username) == null && user.Password == ConfirmPassword)
                {
                    db.Users.Add(user);

                    await db.SaveChangesAsync();

                    await Authenticate(user.Username);

                    return RedirectToPage("index");
                }
                return null;
            }
            return null;
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
