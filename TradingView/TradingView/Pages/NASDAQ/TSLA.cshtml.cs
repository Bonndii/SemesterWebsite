using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TradingView.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace TradingView.Pages.NASDAQ
{
    public class TSLAModel : PageModel
    {
        private UserContext db;

        private Subscription sub;
        public TSLAModel(UserContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public void OnGetSubscribe()
        {
            User user = db.Users.FirstOrDefault(u => u.Username == User.Identity.Name);
            if (db.Subscriptions.FirstOrDefault(s => s.User == user && s.Name == "TSLA" && s.Exchange == "NASDAQ") == null)
            {
                sub = new Subscription();
                sub.User = user;
                sub.Name = "TSLA";
                sub.Exchange = "NASDAQ";
                db.Subscriptions.Add(sub);
                db.SaveChanges();
            }
            else
            {
                db.Subscriptions.Remove(db.Subscriptions.FirstOrDefault(s => s.User == user && s.Name == "TSLA" && s.Exchange == "NASDAQ"));
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
