﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Controllers
{
    public class CouponsController : Controller
    {
        // GET: Admin/Coupons
        public ActionResult Index()
        {
            return View();
        }
    }
}