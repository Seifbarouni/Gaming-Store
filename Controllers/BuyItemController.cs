using System.Threading.Tasks;
using GetAGame.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GetAGame.Controllers
{
    public class BuyItemController : Controller
    {
        private readonly IitemsServices _itemsService;

        public BuyItemController(IitemsServices itemsService)
        {
            _itemsService = itemsService;
        }
        [Authorize]
        public async Task<IActionResult> Buy(int? id)
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