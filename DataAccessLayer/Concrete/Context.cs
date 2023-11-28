using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    // : DbContext ten IdentityDbContext' e cevirdik
    public class Context : IdentityDbContext<AppUser,AppRole, int>
    {
        // kalıtım aldığımız DbContext methodunu override ettik
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S4O1A1P;database=HotelDB;integrated security=true");
        }

        // Entityleri Db ye ekledik

        public DbSet<About>? Abouts { get; set; }
        public DbSet<About2>? About2s { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Destination>? Destinations { get; set; }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<Feature2>? Feature2s { get; set; }
        public DbSet<Guide>? Guides { get; set; }
        public DbSet<Newsletter>? Newsletters { get; set; }
        public DbSet<SubAbout>? SubAbouts { get; set; }
        public DbSet<Testimonial>? Testimonials { get; set; }

        // sonradan yorum table eklendi
        public DbSet<Comment>? Comments { get; set; }
    }
}
