using _16_TranThanhHau_Buoi2_BTVN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_TranThanhHau_Buoi2_BTVN.Controllers
{
    public class Bai11_HomePageController : Controller
    {
        //
        // GET: /Bai11_HomePage/

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult SanPham_Bai11()
        {
            return View();
        }
        public ActionResult Lienhe()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap([Bind(Include = "UserName, Password,Email")]User user)
        {
            if ("huit".Equals(user.UserName) && "123456".Equals(user.Password) && "tranhau2607@gmail.com".Equals(user.Email))
            {
                Session["user"] = new User() { login = user.UserName, UserName = "Trần Thanh Hậu" };
            }
            return RedirectToAction("HomeDNDK", "Bai11_HomeDNDK");
        }

        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(string UserName, string Name, string Email, string Password, string NamSinh, string RetypePassword, string GioiTinh)
        {
            if (UserName.Length >= 2 && Name.Length >= 3 && Password.Length >= 6 && RetypePassword == Password)
                return RedirectToAction("DangNhap", "Bai11_HomePage");
            return View();
        }

    }
}
