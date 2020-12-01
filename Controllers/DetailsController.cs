using System.Threading.Tasks;
using GetAGame.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetAGame.Controllers
{
    public class DetailsController : Controller
    {
        private readonly IitemsServices _itemsService;

        public DetailsController(IitemsServices itemsService)
        {
            _itemsService = itemsService;
        }
        public async Task<IActionResult> Index(int? id)
        {
            var item = await _itemsService.GetItemAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
    }
}