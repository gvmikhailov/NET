using Microsoft.EntityFrameworkCore;


namespace Goods
{
    public partial class Goods
    {
        public long GoodBarCode { get; set; }
        public string ShopId { get; set; }
        public string GoodName { get; set; }
    }

    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"ConnectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Goods> Goods { get; set; }
    }
}
