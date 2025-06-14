using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp5
{
    public partial class HomeBills : DbContext
    {
        public HomeBills()
            : base("name=HomeBills")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillCompany> BillCompanies { get; set; }
        public virtual DbSet<Checking> Checkings { get; set; }
        public virtual DbSet<DebtItem> DebtItems { get; set; }
        public virtual DbSet<Ledger> Ledgers { get; set; }
        public virtual DbSet<OtherBill> OtherBills { get; set; }
        public virtual DbSet<Payday> Paydays { get; set; }
        public virtual DbSet<Recurring> Recurrings { get; set; }
        public virtual DbSet<UserSetting> UserSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .Property(e => e.AmountDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BillCompany>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BillCompany>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<BillCompany>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.BillCompany)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillCompany>()
                .HasOptional(e => e.BillCompany1)
                .WithRequired(e => e.BillCompany2);

            modelBuilder.Entity<BillCompany>()
                .HasMany(e => e.Ledgers)
                .WithRequired(e => e.BillCompany)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Checking>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DebtItem>()
                .Property(e => e.Payee)
                .IsUnicode(false);

            modelBuilder.Entity<DebtItem>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<DebtItem>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ledger>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OtherBill>()
                .Property(e => e.Payee)
                .IsUnicode(false);

            modelBuilder.Entity<OtherBill>()
                .Property(e => e.For)
                .IsUnicode(false);

            modelBuilder.Entity<OtherBill>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OtherBill>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Payday>()
                .HasMany(e => e.BillCompanies)
                .WithRequired(e => e.Payday)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payday>()
                .HasMany(e => e.UserSettings)
                .WithRequired(e => e.Payday)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recurring>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Recurring>()
                .HasMany(e => e.BillCompanies)
                .WithRequired(e => e.Recurring)
                .WillCascadeOnDelete(false);
        }
    }
}
