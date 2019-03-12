namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookDB_Model : DbContext
    {
        public BookDB_Model()
            : base("name=BookDB_Model")
        {
        }

        public virtual DbSet<BookInfo> BookInfo { get; set; }
        public virtual DbSet<BookType> BookType { get; set; }
        public virtual DbSet<BookInfo_View> BookInfo_View { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookInfo>()
                .Property(e => e.BkName)
                .IsUnicode(false);

            modelBuilder.Entity<BookInfo>()
                .Property(e => e.BkPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BookType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<BookInfo_View>()
                .Property(e => e.BkName)
                .IsUnicode(false);

            modelBuilder.Entity<BookInfo_View>()
                .Property(e => e.BkPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BookInfo_View>()
                .Property(e => e.TypeName)
                .IsUnicode(false);
        }
    }
}
