using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using TradingView.Models;

namespace TradingView.Pages.FOREXCOM
{
    public class SPXUSDModel : PageModel
    {
        private UserContext db;

        private Subscription sub;

        public SPXUSDModel(UserContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            
        }

        public void OnGetSubscribe()
        {
            User user = db.Users.FirstOrDefault(u => u.Username == User.Identity.Name);
            if (db.Subscriptions.FirstOrDefault(s => s.User == user && s.Name == "SPXUSD" && s.Exchange == "FOREXCOM") == null)
            {
                sub = new Subscription();
                sub.User = user;
                sub.Name = "SPXUSD";
                sub.Exchange = "FOREXCOM";
                db.Subscriptions.Add(sub);
                db.SaveChanges();
            }
            else
            {
                db.Subscriptions.Remove(db.Subscriptions.FirstOrDefault(s => s.User == user && s.Name == "SPXUSD" && s.Exchange == "FOREXCOM"));
                db.SaveChanges();
            }
        }

        public async Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("Index");
        }
    }
}
