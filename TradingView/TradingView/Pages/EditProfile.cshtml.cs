using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TradingView.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace TradingView.Pages
{
    public class EditProfileModel : PageModel
    {
        private UserContext db;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Firstname { get; set; }

        [BindProperty]
        public string Lastname { get; set; }

        [BindProperty]
        public string CurrentPassword { get; set; }

        [BindProperty]
        public string NewPassword { get; set; }

        public EditProfileModel(UserContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            
        }
        public async Task<IActionResult> OnPost()
        {
            User user = db.Users.FirstOrDefault(u => u.Username == User.Identity.Name);
            if (Username != null && Firstname != null && Lastname != null)
            {
                user.Username = Username;
                await Authenticate(Username);
                user.Firstname = Firstname;
                user.Lastname = Lastname;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToPage("Profile");
            }

            if (CurrentPassword == user.Password && NewPassword != null)
            {
                user.Password = NewPassword;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
            }
            else return null;

            return RedirectToPage("Profile");
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

        public async Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("Index");
        }
    }
}
