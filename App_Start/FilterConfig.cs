﻿using System.Web;
using System.Web.Mvc;

namespace Prova_Sistema_Web_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
