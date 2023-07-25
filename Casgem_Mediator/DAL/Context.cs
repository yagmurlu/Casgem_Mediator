using Microsoft.EntityFrameworkCore;

namespace Casgem_Mediator.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions <Context> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
