using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using UnitConverterMOMTest.Models;
#nullable disable
namespace UnitConverterMOMTest.Data
{
    public class UnitConverterDBContext : DbContext
    {
        public UnitConverterDBContext()
        {
        }
       
        public UnitConverterDBContext(DbContextOptions<UnitConverterDBContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConverterOutput>()
                .HasNoKey();

        }

        public DbSet<ConverterOutput> converterOutput { get; set; }
    }
}
