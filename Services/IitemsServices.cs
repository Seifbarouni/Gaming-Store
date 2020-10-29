using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetAGame.Services
{
    public interface IitemsServices
    {
        Task<List<Models.Item>> GetItems();
        Task<Models.Item> GetItem(int? id);
        Task<List<Models.Item>> GetItemsByName(string name);
        Task DeleteItemById(int id);

        Task AddItem(Models.Item item);

    }
}
