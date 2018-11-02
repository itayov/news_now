﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsNow.Models;
using Newtonsoft.Json;

namespace NewsNow.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly NewsNowContext _context;

        public StatisticsController(NewsNowContext context)
        {
            _context = context;
        }

        // GET: Statistics
        public async Task<IActionResult> Index()
        {
            //return View(await _context.ExampleStatistics.ToListAsync());
            return View();
        }

        public async Task<IActionResult> Comments()
        {
            var monthlyComments = await _context.Comments.GroupBy(x => new { x.DatePosted.Year, x.DatePosted.Month }).ToListAsync();

            var statistics = monthlyComments.Select(monthGroup => new {
                month = monthGroup.First().DatePosted.Month.ToString() + '/' + monthGroup.First().DatePosted.Year.ToString(),
                comments = monthGroup.Count()
            }).ToList();

            return Json(statistics);
        }

        public async Task<IActionResult> Articles()
        {
            var articlesPerCategory = await _context.Articles.GroupBy(x => x.CategoryId).ToListAsync();

            var statistics = articlesPerCategory.Select(categoryArticles => new
            {
                label = _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == categoryArticles.First().CategoryId).Result.Name,
                color = _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == categoryArticles.First().CategoryId).Result.HexColor,
                value = categoryArticles.Count()
            }).ToList();

            return Json(statistics);
        }
    }
}