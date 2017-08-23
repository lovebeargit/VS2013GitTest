using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.DAL;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext db = new AccountContext();

        //
        // GET: /Account/
        public ActionResult Index()
        {
            //var Model= db.SysUser;
            return View(db.SysUser);
        }

        public ActionResult Details()
        {
            //var id= 
            return View(db.SysUser);
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "Hello";
            return View();
        }


        public ActionResult Register()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string name = fc["i1"];
            string psw = fc["i2"];
            var user = db.SysUser.Where(b=>b.UserName==name & b.password==psw);
            if (user.Count() > 0)
            {
                
                ViewBag.LoginState = "Hello," + name;
            }
            else
            {
                ViewBag.LoginState = "不存在" + name;
            }
            return RedirectToAction("Index");
        }


	}
}