﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScandinavianFood.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Recipes()
        {
            return View();
        }
    }
}
