using System.Threading.Tasks;
using GetAGame.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetAGame.Controllers
{
    public class DeleteItemController : Controller
    {
        private readonly IitemsServices _itemsService;

        public DeleteItemController(IitemsServices itemsService)
        {
            _itemsService = itemsService;
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _itemsService.DeleteItemById(id);
            return Redirect("/Home");
        }
    }
}