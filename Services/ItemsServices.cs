using GetAGame.Data;
using GetAGame.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Item>> GetItemsAsync()
        {
            var items = from m in _dbcontext.ArticlesOfGetAGame select m;
            return await items.ToListAsync();
        }
        public async Task<Item> GetItemAsync(int? id)
        {
            return await _dbcontext.ArticlesOfGetAGame.FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task<List<Item>> GetItemsByNameAsync(string name)
        {
            var items = from i in _dbcontext.ArticlesOfGetAGame where i.OwnerName == name select i;
            return await items.ToListAsync();
        }
        public async Task DeleteItemByIdAsync(int id)
        {
            _dbcontext.ArticlesOfGetAGame.Remove(_dbcontext.ArticlesOfGetAGame.FirstOrDefault(i => i.Id == id));
            await _dbcontext.SaveChangesAsync();
        }
        public async Task AddItemAsync(Models.Item item)
        {
            await _dbcontext.ArticlesOfGetAGame.AddAsync(item);
            await _dbcontext.SaveChangesAsync();
        }

    }
}
