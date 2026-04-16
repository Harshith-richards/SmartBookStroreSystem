using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartBookStroreSystem.Models;

namespace SmartBookStroreSystem.DTOs
{
    //By inheriting from IdentityDbContext, SmartBookContext can leverage the built-in identity management features
    //while also defining additional DbSet properties for the application's specific data models (Books, Orders, OrderItems, Payments).
    public class SmartBookContext : IdentityDbContext<UserModel>
    {
        public SmartBookContext(DbContextOptions<SmartBookContext> options) 
            : base(options)
        {
        }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderItemModel> OrderItems { get; set; }
        public DbSet<PaymentModel> Payments { get; set; }
    }
}
