using Microsoft.EntityFrameworkCore;
using TiemSach.Shared;

namespace TiemSach.Server
{
    public class TiemSachDbContext : DbContext
    {
        public TiemSachDbContext(DbContextOptions<TiemSachDbContext> options)
          : base(options) { }

        public DbSet<Sach> Sachs { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var sachEntity = modelBuilder.Entity<Sach>();
            sachEntity.HasKey(sach => sach.Id);
            sachEntity.Property(sach => sach.Name)
            .HasMaxLength(80);
            sachEntity.Property(sach => sach.Price)
            .HasColumnType("money");
            sachEntity.Property(sach => sach.Loaisach)
            .HasConversion<string>();

            var ordersEntity = modelBuilder.Entity<Order>();
            ordersEntity.HasKey(order => order.Id);
            ordersEntity.HasOne(order => order.Customer);
            ordersEntity.HasMany(order => order.Sachs)
            .WithMany(sach => sach.Orders);

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.Id);
            customerEntity.Property(customer => customer.Name)
            .HasMaxLength(100);
            customerEntity.Property(customer => customer.Street)
            .HasMaxLength(50);
            customerEntity.Property(customer => customer.City)
            .HasMaxLength(50);
        }
    }
}
