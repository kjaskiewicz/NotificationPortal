﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotificationPortal.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Notifications
        public ActionResult Notifications()
        {
            return View();
        }

        // GET: Notifications
        public ActionResult Qpx()
        {
            return View();
        }
    }
}