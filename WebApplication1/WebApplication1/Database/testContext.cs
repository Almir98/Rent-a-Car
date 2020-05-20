using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Database
{
    public partial class testContext : DbContext
    {
        public testContext()
        {
        }

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<BranchVehicle> BranchVehicle { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<FuelType> FuelType { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=test;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(x => x.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking__Custome__4E88ABD4");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(x => x.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking__Vehicle__4F7CD00D");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CloseTime).HasColumnType("datetime");

                entity.Property(e => e.DateTimeofComment).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OpenTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(x => x.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Branch__CityID__571DF1D5");
            });

            modelBuilder.Entity<BranchVehicle>(entity =>
            {
                entity.Property(e => e.BranchVehicleId).HasColumnName("BranchVehicleID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchVehicle)
                    .HasForeignKey(x => x.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BranchVeh__Branc__5AEE82B9");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.BranchVehicle)
                    .HasForeignKey(x => x.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BranchVeh__Vehic__59FA5E80");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateTimeofComment).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(x => x.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__Custome__619B8048");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(x => x.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__Vehicle__628FA481");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(x => x.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer__CityID__3E52440B");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(x => x.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer__Custom__3D5E1FD2");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FuelType>(entity =>
            {
                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.FuelName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.ManufacturerName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.HasOne(d => d.Manufacturer)
                //    //.WithMany(p => p.Model)
                //    .HasForeignKey(x => x.ManufacturerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Model__Manufactu__46E78A0C");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(x => x.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Payment__Booking__5441852A");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(x => x.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Payment__Custome__52593CB8");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(x => x.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Payment__Payment__534D60F1");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.RatingId).HasColumnName("RatingID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(x => x.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rating__Customer__5DCAEF64");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(x => x.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rating__VehicleI__5EBF139D");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.ManufacturerDate).HasColumnType("datetime");

                entity.Property(e => e.Mileage).HasMaxLength(15);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.RegistrationNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Transmission)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleTypeID");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(x => x.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vehicle__FuelTyp__49C3F6B7");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(x => x.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vehicle__ModelID__4BAC3F29");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(x => x.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vehicle__Vehicle__4AB81AF0");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.HasKey(x => x.VehcileTypeId)
                    .HasName("PK__VehicleT__E7E1A59FB96484C8");

                entity.Property(e => e.VehcileTypeId).HasColumnName("VehcileTypeID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
