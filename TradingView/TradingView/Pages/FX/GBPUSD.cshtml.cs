using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using TradingView.Models;

namespace TradingView.Pages.FX
{
    public class GBPUSDModel : PageModel
    {
        private UserContext db;

        private Subscription sub;

        public GBPUSDModel(UserContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public void OnGetSubscribe()
        {
            User user = db.Users.FirstOrDefault(u => u.Username == User.Identity.Name);
            if (db.Subscriptions.FirstOrDefault(s => s.User == user && s.Name == "GBPUSD" && s.Exchange == "FX") == null)
            {
                sub = new Subscription();
                sub.User = user;
                sub.Name = "GBPUSD";
                sub.Exchange = "FX";
                db.Subscriptions.Add(sub);
                db.SaveChanges();
            }
            else
            {
                db.Subscriptions.Remove(db.Subscriptions.FirstOrDefault(s => s.User == user && s.Name == "GBPUSD" && s.Exchange == "FX"));
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
