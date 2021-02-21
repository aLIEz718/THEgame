using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using THEgame.ViewModels; // пространство имен моделей RegisterModel и LoginModel
using THEgame.Models; // пространство имен UserContext и класса User
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Web;
using System.Collections.Specialized;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using System.Net;
namespace THEgame.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("logchecky"))
            {
                HttpContext.Response.Cookies.Append("logcheckn", "n");

                return View();
            }
            else {
                if (HttpContext.Request.Cookies.ContainsKey("logcheckn"))
                {
                    HttpContext.Response.Cookies.Delete("logchecky");
                    HttpContext.Response.Cookies.Delete("Name");
                    return View();
                }
                else { 
                return Redirect("/Home/Index");
                }
            }
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (HttpContext.Request.Cookies.ContainsKey("logcheckn"))
            {
                if (model.Name == "Admin" && model.Password == "Admin")
                {
                    HttpContext.Response.Cookies.Append("logchecky", "y");
                    HttpContext.Response.Cookies.Append("Name", "Admin");
                    return Redirect("/Home/Index");
                }
                else
                {
                    return View();
                }
            }
            else {
                return View();
            }
        }
    }
}
