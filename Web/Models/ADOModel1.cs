namespace Web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ADOModel1 : DbContext
    {
        public ADOModel1()
            : base("name=ADOModel1")
        {
        }

        public virtual DbSet<AccountRecord> AccountRecord { get; set; }
        public virtual DbSet<AccumulationFund> AccumulationFund { get; set; }
        public virtual DbSet<BaseAudit> BaseAudit { get; set; }
        public virtual DbSet<CostParameterSetting> CostParameterSetting { get; set; }
        public virtual DbSet<EnterpriseSocialSecurity> EnterpriseSocialSecurity { get; set; }
        public virtual DbSet<Information> Information { get; set; }
        public virtual DbSet<LoanSubject> LoanSubject { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<MemberLoan> MemberLoan { get; set; }
        public virtual DbSet<MemberLoanAudit> MemberLoanAudit { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SocialSecurity> SocialSecurity { get; set; }
        public virtual DbSet<SocialSecurityPeople> SocialSecurityPeople { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<FreezingAmountInstruction> FreezingAmountInstruction { get; set; }
        public virtual DbSet<LoanAnswer> LoanAnswer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccumulationFund>()
                .Property(e => e.StopMethod)
                .IsUnicode(false);

            modelBuilder.Entity<BaseAudit>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<BaseAudit>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<LoanSubject>()
                .HasMany(e => e.LoanAnswer)
                .WithOptional(e => e.LoanSubject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MemberLoanAudit>()
                .Property(e => e.LoanTerm)
                .IsFixedLength();

            modelBuilder.Entity<MemberLoanAudit>()
                .Property(e => e.LoanMethod)
                .IsFixedLength();

            modelBuilder.Entity<MemberLoanAudit>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithOptional(e => e.Order)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.ParentCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SocialSecurity>()
                .Property(e => e.StopMethod)
                .IsUnicode(false);

            modelBuilder.Entity<SocialSecurity>()
                .Property(e => e.StopReason)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.RegType)
                .IsUnicode(false);
        }
    }
}
