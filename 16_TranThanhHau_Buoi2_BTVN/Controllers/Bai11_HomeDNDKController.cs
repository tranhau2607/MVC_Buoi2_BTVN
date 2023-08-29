using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_TranThanhHau_Buoi2_BTVN.Controllers
{
    public class Bai11_HomeDNDKController : Controller
    {
        //
        // GET: /Bai11_HomeDNDK/

        public ActionResult HomeDNDK()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("DangNhap", "Bai11_HomePage");
            }
            return View();
        }

    }
}
