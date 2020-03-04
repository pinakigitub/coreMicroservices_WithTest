using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistance.EF
{
    public partial class kwooncjpContext : DbContext
    {
        public kwooncjpContext()
        {
        }

        public kwooncjpContext(DbContextOptions<kwooncjpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Animalinfo> Animalinfo { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<PlayerMatchdetails> PlayerMatchdetails { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Productinfos> Productinfos { get; set; }
        public virtual DbSet<StripeUserAddresses> StripeUserAddresses { get; set; }
        public virtual DbSet<StripeUsers> StripeUsers { get; set; }
        public virtual DbSet<StripeUserShippingAddresses> StripeUserShippingAddresses { get; set; }
        public virtual DbSet<UserCrens> UserCrens { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseNpgsql("Host=arjuna.db.elephantsql.com;Database=kwooncjp;Username=kwooncjp;Password=IekM4sNWWFoK20jlYFEIpY8LO7D56E2B");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("btree_gin")
                .HasPostgresExtension("btree_gist")
                .HasPostgresExtension("citext")
                .HasPostgresExtension("cube")
                .HasPostgresExtension("dblink")
                .HasPostgresExtension("dict_int")
                .HasPostgresExtension("dict_xsyn")
                .HasPostgresExtension("earthdistance")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("hstore")
                .HasPostgresExtension("intarray")
                .HasPostgresExtension("ltree")
                .HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("pgrowlocks")
                .HasPostgresExtension("pgstattuple")
                .HasPostgresExtension("tablefunc")
                .HasPostgresExtension("unaccent")
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("xml2");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("account");

                entity.HasIndex(e => e.Email)
                    .HasName("account_email_key")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Token).HasColumnName("token");
            });

            modelBuilder.Entity<Animalinfo>(entity =>
            {
                entity.ToTable("animalinfo");

                entity.Property(e => e.AnimalinfoId).HasColumnName("animalinfoId");

                entity.Property(e => e.Animalid).HasColumnName("animalid");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<PlayerMatchdetails>(entity =>
            {
                entity.ToTable("player_matchdetails");

                entity.Property(e => e.PlayerMatchdetailsId).HasColumnName("player_matchdetails_id");

                entity.Property(e => e.Noofonedaymatch).HasColumnName("noofonedaymatch");

                entity.Property(e => e.Nooftestmatch).HasColumnName("nooftestmatch");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerMatchdetails)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("player_matchdetails_player_id_fkey");
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("players");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname1).HasColumnName("Lastname");
            });

            modelBuilder.Entity<Productinfos>(entity =>
            {
                entity.ToTable("productinfos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Productname)
                    .HasColumnName("productname")
                    .HasMaxLength(50);

                entity.Property(e => e.Unitprice).HasColumnName("unitprice");
            });

            modelBuilder.Entity<StripeUserAddresses>(entity =>
            {
                entity.ToTable("stripeUserAddresses");

                entity.HasIndex(e => e.StripeCustId)
                    .HasName("stripeUserAddresses_stripe_custId_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Line1)
                    .HasColumnName("line1")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(255);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.StripeCustId)
                    .HasColumnName("stripe_custId")
                    .HasMaxLength(255);

                entity.Property(e => e.StripeUserId).HasColumnName("stripeUserId");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.StripeUser)
                    .WithMany(p => p.StripeUserAddresses)
                    .HasForeignKey(d => d.StripeUserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("stripeUserAddresses_stripeUserId_fkey");
            });

            modelBuilder.Entity<StripeUsers>(entity =>
            {
                entity.ToTable("stripeUsers");

                entity.HasIndex(e => e.MobileNo)
                    .HasName("stripeUsers_mobileNo_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Coupon)
                    .HasColumnName("coupon")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.IsPaymentodMethodeAdded).HasColumnName("isPaymentodMethodeAdded");

                entity.Property(e => e.MobileNo).HasColumnName("mobileNo");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.PlanType)
                    .HasColumnName("planType")
                    .HasMaxLength(255);

                entity.Property(e => e.StripeCustId)
                    .HasColumnName("stripe_custId")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<StripeUserShippingAddresses>(entity =>
            {
                entity.ToTable("stripeUserShippingAddresses");

                entity.HasIndex(e => e.StripeCustId)
                    .HasName("stripeUserShippingAddresses_stripe_custId_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Line1)
                    .HasColumnName("line1")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(255);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.StripeCustId)
                    .HasColumnName("stripe_custId")
                    .HasMaxLength(255);

                entity.Property(e => e.StripeUserId).HasColumnName("stripeUserId");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.StripeUser)
                    .WithMany(p => p.StripeUserShippingAddresses)
                    .HasForeignKey(d => d.StripeUserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("stripeUserShippingAddresses_stripeUserId_fkey");
            });

            modelBuilder.Entity<UserCrens>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("timestamp with time zone");
            });
        }
    }
}
