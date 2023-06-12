using AppleStoreTupinikim.Models;
using Microsoft.EntityFrameworkCore;

namespace AppleStoreTupinikim.Data
{
    public class Context : Microsoft.EntityFrameworkCore.DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<UserModel> User { get; set; }
    }
}
