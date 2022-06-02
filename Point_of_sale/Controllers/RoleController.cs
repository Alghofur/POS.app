﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Point_of_sale.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {


                if (!isAdminUser())
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        private bool isAdminUser()
        {
            throw new NotImplementedException();
        }
    }
}