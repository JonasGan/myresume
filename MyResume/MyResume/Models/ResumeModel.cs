namespace MyResume.Models
{
    using System.Data.Entity;

    public partial class ResumeModel : DbContext
    {
        public ResumeModel()
            : base("name=ResumeModel")
        {
        }

        public virtual DbSet<Table_User> Table_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_User>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<Table_User>()
                .Property(e => e.userEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Table_User>()
                .Property(e => e.userPostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Table_User>()
                .Property(e => e.userMobile)
                .IsUnicode(false);
        }
    }
}
