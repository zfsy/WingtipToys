using System.Data.Entity;
namespace WingtipToys.Models
{
    /// <summary>
    /// 上下文类,用于管理实体类,并提供对数据库的数据访问
    /// </summary>
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingtipToys")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}