using Microsoft.EntityFrameworkCore;

namespace WebApiSecond.Models
{
    public class VodaContext : DbContext
    {
        public VodaContext(DbContextOptions<VodaContext> options) : base(options)
        {

        }

        public DbSet<VodaModel> Voda { get; set; }
        public DbSet<VodaTypeModel> VodaType { get; set; }
    }
}
