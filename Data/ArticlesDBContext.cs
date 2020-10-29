using Microsoft.EntityFrameworkCore;

namespace GetAGame.Data
{
    public class ArticlesDBContext : DbContext
    {
        public ArticlesDBContext(DbContextOptions<ArticlesDBContext> opt) : base(opt)
        { }
        public DbSet<GetAGame.Models.Item> ArticlesOfGetAGame { get; set; }
    }
}