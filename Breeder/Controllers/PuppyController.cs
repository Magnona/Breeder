using System;
using System.Diagnostics;
using Breeder.Framework.Repositories;
using Breeder.Models;
using BreederWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BreederWeb.Controllers
{

    public class PuppyController : Controller
    {
        private static IConfigurationRoot _configuration;

        public PuppyController(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Puppy()
        {
            var model = new PuppyViewModel(_configuration);
            model.Init();
            return View(model);
        }

        //Edit

    }
}
