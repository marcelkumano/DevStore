using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevStore.Infra.DataContexts
{
    public class DevStoreDataContext : DbContext
    {
        public DevStoreDataContext() : base(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBDevStore;Data Source=NOTE-DELL-MARCE\SQLEXPRESS")
        {
            Database.SetInitializer<DevStoreDataContext>(new DevStoreDataContextInitializer());
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mappings.ProductMap());
            modelBuilder.Configurations.Add(new Mappings.CategoryMap());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Domain.Product> Products { get; set; }

        public DbSet<Domain.Category> Category { get; set; }

    }

    public class DevStoreDataContextInitializer : DropCreateDatabaseIfModelChanges<DevStoreDataContext>
    {
        protected override void Seed(DevStoreDataContext context)
        {
            context.Category.Add(new Domain.Category() { Id = 1, Title = "Informática" });
            context.Category.Add(new Domain.Category() { Id = 2, Title = "Games" });
            context.Category.Add(new Domain.Category() { Id = 3, Title = "Papelaria" });
            context.SaveChanges();

            context.Products.Add(new Domain.Product() { Id = 1, CategoryId = 1, IsActive = true, Title = "Produto 1" });
            context.Products.Add(new Domain.Product() { Id = 2, CategoryId = 1, IsActive = true, Title = "Produto 2" });
            context.Products.Add(new Domain.Product() { Id = 3, CategoryId = 1, IsActive = true, Title = "Produto 3" });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
