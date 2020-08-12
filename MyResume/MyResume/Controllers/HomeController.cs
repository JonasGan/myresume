using System;
using System.Linq;
using System.Web.Mvc;
using MyResume.Models;
using System.Configuration;
using System.Data.Entity;
namespace MyResume.Controllers
{
    public class HomeController : Controller
    {
        // To display the Home page
        public ActionResult Home() 
        {
            Table_User user;
            using (var context = new ResumeModel())
            {
                user = context.Table_User.FirstOrDefault(r => r.userid == 1);
            }
            return View(user);
        }

        //To update the user profile
        [HttpPost]
        public ActionResult UpdateUser([Bind(Exclude = "last_update_date")] Table_User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var context = new ResumeModel())
                    {
                        context.Entry(user).State = EntityState.Modified;
                        user.last_update_date = DateTime.Now;
                        context.SaveChanges();
                    }
                    ViewBag.Message = "Profile updated successfully/ 賬號修改成功";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error in updating profile";
            }

            return View("Home");
        }
    }
    
}