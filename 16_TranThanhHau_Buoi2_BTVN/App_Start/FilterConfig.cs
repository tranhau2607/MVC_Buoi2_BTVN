﻿using System.Web;
using System.Web.Mvc;

namespace _16_TranThanhHau_Buoi2_BTVN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}