namespace Application.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model16")
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<advertise_site> advertise_site { get; set; }
        public virtual DbSet<Advertising> Advertisings { get; set; }
        public virtual DbSet<Catagory> Catagories { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<PhotoGallerey> PhotoGallereys { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<We_contact> We_contact { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>()
                .HasMany(e => e.Shops)
                .WithOptional(e => e.Catagory)
                .HasForeignKey(e => e.Catagory_id);

            modelBuilder.Entity<Product>()
                .Property(e => e.About)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Images)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Product_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Likes)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Product_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Rates)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Product_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Types)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Product_id);

            modelBuilder.Entity<Shop>()
                .Property(e => e.About)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.PhotoGallereys)
                .WithOptional(e => e.Shop)
                .HasForeignKey(e => e.Shop_id);

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Shop)
                .HasForeignKey(e => e.Shop_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Likes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Likes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.User_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Rates)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_id);
        }
    }
}
