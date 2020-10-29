using System.Threading.Tasks;
using GetAGame.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GetAGame.Controllers

{
    public class AddItemController : Controller
    {
        private readonly IitemsServices _itemsService;

        public AddItemController(IitemsServices itemsService)
        {
            _itemsService = itemsService;
        }
        [Authorize]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProcess([Bind("Title,ImgURL,Details,Price")] Models.Item item)
        {
            item.OwnerName = User.Identity.Name;
            await _itemsService.AddItem(item);
            return Redirect("/Home");
        }
    }
}