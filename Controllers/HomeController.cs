using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GetAGame.Models;
using GetAGame.Services;
using Microsoft.AspNetCore.Authorization;

namespace GetAGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IitemsServices _itemsService;

        public HomeController(ILogger<HomeController> logger, IitemsServices itemsService)
        {
            _logger = logger;
            _itemsService = itemsService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _itemsService.GetItemsAsync());
        }

        public async Task<IActionResult> MyItems(string name)
        {
            var items = await _itemsService.GetItemsByNameAsync(name);
            return View(items);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
