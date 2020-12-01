using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetAGame.Services
{
    public interface IitemsServices
    {
        Task<List<Models.Item>> GetItemsAsync();
        Task<Models.Item> GetItemAsync(int? id);
        Task<List<Models.Item>> GetItemsByNameAsync(string name);
        Task DeleteItemByIdAsync(int id);

        Task AddItemAsync(Models.Item item);

    }
}
