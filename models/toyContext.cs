using System.Data.Entity;
using WebApplication1.models;

namespace toishop.Models
{
    public class toyContext : DbContext
    {
        public toyContext() : base("toyshop")
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<toy> Toys { get; set; }
    }
}