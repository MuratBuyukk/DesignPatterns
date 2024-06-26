﻿using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Basic Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(65.99);
            ViewBag.v4 = netflixPlans.Content("Movie-Series");
            ViewBag.v5 = netflixPlans.Resolution("480px");

            return View();
        }

        public IActionResult StandardPlanIndex()
        {
            NetflixPlans netflixPlans = new StandardPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standard Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(94.99);
            ViewBag.v4 = netflixPlans.Content("Movie-Series-Animation");
            ViewBag.v5 = netflixPlans.Resolution("720px");

            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new StandardPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(134.99);
            ViewBag.v4 = netflixPlans.Content("Movie-Series-Animation-Documentary");
            ViewBag.v5 = netflixPlans.Resolution("1080px");

            return View();
        }
    }
}
