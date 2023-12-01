//using Data.Entities;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
using Data.Entities;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser() { Id = Guid.NewGuid().ToString(), UserName = "adam@wsei.pl", Email = "adam@wsei.pl", EmailConfirmed = true, NormalizedUserName="ADAM@WSEI.PL" };
            
            user.PasswordHash = ph.HashPassword(user,"1234Ab!");

            modelBuilder.Entity<IdentityUser>().HasData(user);

            var adminRole = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "admin", NormalizedName = "ADMIN" };
            adminRole.ConcurrencyStamp = adminRole.Id;

            modelBuilder.Entity<IdentityRole>().HasData(adminRole);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>() { RoleId = adminRole.Id, UserId = user.Id});

            modelBuilder.Entity<ContactEntity>().HasOne(c => c.Organization).WithMany(o => o.Contacts).HasForeignKey(c => c.OrgznizationId);

            modelBuilder.Entity<OrganizationEntity>().HasData(new OrganizationEntity() { Id = 1, Name = "WSEI", Description = "Uczelnia wyższa w Krakowie" });

            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() { Id = 1, Name = "Adam", Email = "adam@wsei.edu.pl", Phone = "127813268163", Birth = new DateTime(2000, 10, 10), Priority = 1, OrgznizationId = 1},
                new ContactEntity() { Id = 2, Name = "Ewa", Email = "ewa@wsei.edu.pl", Phone = "293443823478", Birth = new DateTime(1999, 8, 10), Priority = 2, OrgznizationId = 1}
            );

            modelBuilder.Entity<OrganizationEntity>().OwnsOne(o => o.Address).HasData(new { OrganizationEntityId = 1, City = "Kraków", Street="Św. Filipa 17", PostalCode = "31-150"});
        }
    }
}