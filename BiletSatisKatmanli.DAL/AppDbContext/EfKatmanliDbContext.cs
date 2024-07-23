using BiletSatisKatmanli.DAL.Configurations;
using BiletSatisKatmanli.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.DAL.AppDbContext
{
    // UI ile db arasında kullanılacak katman BLLdir. Bizi db ye götüren katman DAL dır.
    //Repositories ve Configurations yine DAL da olmak zorundadır.
    public class EfKatmanliDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Eventt> Events { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
            // Contextten gelen bir metotu override ediyoruz
        {

            SetBaseProperties();
            // Base Propertyleri düzenle

            return base.SaveChanges();
        }

        private void SetBaseProperties()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in entries)
            {
                SetIfAdded(entry);
                SetIfModified(entry);
                SetIfDeleted(entry);

            }
        }

        private void SetIfDeleted(EntityEntry<BaseEntity> entry)
        {
            if (entry.State != EntityState.Deleted)
            {
               return;
                // gelen entrynin state i delete değil ise direkt olduğu gibi metodu terk et

            }
            if (entry.Entity is not AuditableEntity entity)
            {
                return;
                // Auditable değilse denetlenebilir değildir. BaseEntityden geliyor
                // demektir yani hard delete direkt metottan çık
            }
            entry.State = EntityState.Modified;
            
            entity.DeletedDate = DateTime.UtcNow;
            entity.Status = ENTITY.Enums.Status.Deleted;
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.Status = ENTITY.Enums.Status.Modified;
                entry.Entity.CreateDate = DateTime.Now;

            }
        }

        private void SetIfAdded(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.Status = ENTITY.Enums.Status.Added;
                entry.Entity.CreateDate = DateTime.Now;

            }
        }
    }

}
}
