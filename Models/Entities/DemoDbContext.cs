
using Microsoft.EntityFrameworkCore;

namespace DemoInterfaceService.Models.Entities
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext() { }
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }
        //DbSet Here
        public DbSet<Khoa> khoas { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=Default");
    }
}
