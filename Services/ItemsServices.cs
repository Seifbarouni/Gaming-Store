using GetAGame.Data;
using GetAGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetAGame.Services
{
    public class ItemsServices : IitemsServices
    {
        private readonly ArticlesDBContext _dbcontext;

        public ItemsServices(Data.ArticlesDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Item>> GetItems()
        {
            return _dbcontext.ArticlesOfGetAGame.ToList();
        }
        public async Task<Item> GetItem(int? id)
        {
            return _dbcontext.ArticlesOfGetAGame.FirstOrDefault(i => i.Id == id);
        }
        public async Task<List<Item>> GetItemsByName(string name)
        {
            var items = (from i in _dbcontext.ArticlesOfGetAGame where i.OwnerName == name select i).ToList();
            //System.Console.WriteLine(items.Count());
            return items.ToList();
        }
        public async Task DeleteItemById(int id)
        {
            _dbcontext.ArticlesOfGetAGame.Remove(_dbcontext.ArticlesOfGetAGame.FirstOrDefault(i => i.Id == id));
            await _dbcontext.SaveChangesAsync();
        }
        public async Task AddItem(Models.Item item)
        {
            await _dbcontext.ArticlesOfGetAGame.AddAsync(item);
            await _dbcontext.SaveChangesAsync();
        }

    }
}
