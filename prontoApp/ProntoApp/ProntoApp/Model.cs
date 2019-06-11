namespace ProntoApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ProntoModel")
        {
        }

        public virtual DbSet<tblImage> tblImages { get; set; }
        public virtual DbSet<tblImageType> tblImageTypes { get; set; }
        public virtual DbSet<tblManifest> tblManifests { get; set; }
        public virtual DbSet<tblManifestPackage> tblManifestPackages { get; set; }
        public virtual DbSet<tblOrder> tblOrders { get; set; }
        public virtual DbSet<tblOrderProduct> tblOrderProducts { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblStatu> tblStatus { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserAddress> tblUserAddresses { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblImage>()
                .Property(e => e.tblImageID)
                .IsUnicode(false);

            modelBuilder.Entity<tblImage>()
                .Property(e => e.PackageID)
                .IsUnicode(false);

            modelBuilder.Entity<tblImage>()
                .Property(e => e.tblManifestPackageID)
                .IsUnicode(false);

            modelBuilder.Entity<tblImageType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblImageType>()
                .HasMany(e => e.tblImages)
                .WithRequired(e => e.tblImageType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblManifest>()
                .Property(e => e.tblManifestId)
                .IsUnicode(false);

            modelBuilder.Entity<tblManifest>()
                .Property(e => e.tblUserId)
                .IsUnicode(false);

            modelBuilder.Entity<tblManifest>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tblManifest>()
                .HasMany(e => e.tblManifestPackages)
                .WithRequired(e => e.tblManifest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblManifestPackage>()
                .Property(e => e.tblManifestPackageID)
                .IsUnicode(false);

            modelBuilder.Entity<tblManifestPackage>()
                .Property(e => e.PackageID)
                .IsUnicode(false);

            modelBuilder.Entity<tblManifestPackage>()
                .Property(e => e.tblOrderProductID)
                .IsUnicode(false);

            modelBuilder.Entity<tblManifestPackage>()
                .Property(e => e.tblManifestID)
                .IsUnicode(false);

            modelBuilder.Entity<tblManifestPackage>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tblManifestPackage>()
                .HasMany(e => e.tblImages)
                .WithRequired(e => e.tblManifestPackage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.tblOrderID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.DeliveryAddressID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.tblUserID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrder>()
                .HasMany(e => e.tblOrderProducts)
                .WithRequired(e => e.tblOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrderProduct>()
                .Property(e => e.tblOrderProductID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrderProduct>()
                .Property(e => e.tblOrderID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrderProduct>()
                .Property(e => e.tblProductID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrderProduct>()
                .HasMany(e => e.tblManifestPackages)
                .WithRequired(e => e.tblOrderProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.tblProductID)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .HasMany(e => e.tblOrderProducts)
                .WithRequired(e => e.tblProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRole>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblRole>()
                .HasMany(e => e.tblUserRoles)
                .WithRequired(e => e.tblRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblStatu>()
                .HasMany(e => e.tblImages)
                .WithRequired(e => e.tblStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblStatu>()
                .HasMany(e => e.tblManifests)
                .WithRequired(e => e.tblStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblStatu>()
                .HasMany(e => e.tblManifestPackages)
                .WithRequired(e => e.tblStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblStatu>()
                .HasMany(e => e.tblOrders)
                .WithRequired(e => e.tblStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblStatu>()
                .HasMany(e => e.tblOrderProducts)
                .WithRequired(e => e.tblStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.tblUserID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblManifests)
                .WithRequired(e => e.tblUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblOrders)
                .WithRequired(e => e.tblUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblUserAddresses)
                .WithRequired(e => e.tblUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblUserRoles)
                .WithRequired(e => e.tblUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUserAddress>()
                .Property(e => e.tblUserAddressID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserAddress>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserAddress>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserAddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserAddress>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserAddress>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserAddress>()
                .Property(e => e.tblUserID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUserAddress>()
                .HasMany(e => e.tblOrders)
                .WithRequired(e => e.tblUserAddress)
                .HasForeignKey(e => e.DeliveryAddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUserRole>()
                .Property(e => e.tblUserID)
                .IsUnicode(false);
        }
    }
}
