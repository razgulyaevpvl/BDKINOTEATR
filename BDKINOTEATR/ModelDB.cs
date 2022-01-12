using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BDKINOTEATR
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Bilet> Bilet { get; set; }
        public virtual DbSet<Chek> Chek { get; set; }
        public virtual DbSet<Doljnost> Doljnost { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<KategoriyaBileta> KategoriyaBileta { get; set; }
        public virtual DbSet<Mesto> Mesto { get; set; }
        public virtual DbSet<Roli> Roli { get; set; }
        public virtual DbSet<Seans> Seans { get; set; }
        public virtual DbSet<Sotrydnik> Sotrydnik { get; set; }
        public virtual DbSet<Strana> Strana { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zal> Zal { get; set; }
        public virtual DbSet<Zhanr> Zhanr { get; set; }
        public virtual DbSet<Avtorizaciya> Avtorizaciya { get; set; }
        public virtual DbSet<IstoriyaSeansov> IstoriyaSeansov { get; set; }
        public virtual DbSet<Chek_Bileta> Chek_Bileta { get; set; }
        public virtual DbSet<Seans_Bilet> Seans_Bilet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bilet>()
                .Property(e => e.CenaBileta)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Chek>()
                .Property(e => e.Cena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Doljnost>()
                .Property(e => e.Zarplata)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Doljnost>()
                .HasMany(e => e.Sotrydnik)
                .WithOptional(e => e.Doljnost)
                .WillCascadeOnDelete();

            modelBuilder.Entity<KategoriyaBileta>()
                .HasMany(e => e.Bilet)
                .WithOptional(e => e.KategoriyaBileta)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Roli>()
                .HasMany(e => e.Avtorizaciya)
                .WithOptional(e => e.Roli)
                .HasForeignKey(e => e.IDRols);

            modelBuilder.Entity<Seans>()
                .HasMany(e => e.Bilet)
                .WithOptional(e => e.Seans)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sotrydnik>()
                .HasMany(e => e.Chek)
                .WithOptional(e => e.Sotrydnik)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Strana>()
                .HasMany(e => e.Film)
                .WithOptional(e => e.Strana)
                .HasForeignKey(e => e.IDStrana);

            modelBuilder.Entity<Zal>()
                .HasMany(e => e.Seans)
                .WithOptional(e => e.Zal)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Chek_Bileta>()
                .Property(e => e.Cena)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Chek_Bileta>()
                .Property(e => e.Zarplata)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Chek_Bileta>()
                .Property(e => e.CenaBileta)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Seans_Bilet>()
                .Property(e => e.CenaBileta)
                .HasPrecision(19, 4);
        }
    }
}
