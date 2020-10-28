using Microsoft.EntityFrameworkCore;


namespace Goods
{
    public partial class Goods
    {
        public long GoodBarCode { get; set; }
        public string ShopId { get; set; }
        public string GoodName { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<Goods> Goods { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"ConnectionString");
        }
    }
}
