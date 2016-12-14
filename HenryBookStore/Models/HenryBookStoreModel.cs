namespace HenryBookStore.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HenryBookStoreModel : DbContext
    {
        public HenryBookStoreModel()
            : base("name=HenryBookStoreModelConnection")
        {
        }

        public virtual DbSet<AUTHOR> AUTHORs { get; set; }
        public virtual DbSet<BOOK> BOOKs { get; set; }
        public virtual DbSet<BRANCH> BRANCHes { get; set; }
        public virtual DbSet<INVENTORY> INVENTORies { get; set; }
        public virtual DbSet<PUBLISHER> PUBLISHERs { get; set; }
        public virtual DbSet<WROTE> WROTEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AUTHOR>()
                .Property(e => e.AUTHOR_LAST)
                .IsUnicode(false);

            modelBuilder.Entity<AUTHOR>()
                .Property(e => e.AUTHOR_FIRST)
                .IsUnicode(false);

            modelBuilder.Entity<AUTHOR>()
                .HasMany(e => e.WROTEs)
                .WithRequired(e => e.AUTHOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOK>()
                .Property(e => e.BOOK_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BOOK>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<BOOK>()
                .Property(e => e.PUBLISHER_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BOOK>()
                .Property(e => e.TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BOOK>()
                .Property(e => e.PRICE)
                .HasPrecision(6, 2);

            modelBuilder.Entity<BOOK>()
                .HasMany(e => e.INVENTORies)
                .WithRequired(e => e.BOOK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOK>()
                .HasMany(e => e.WROTEs)
                .WithRequired(e => e.BOOK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BRANCH>()
                .Property(e => e.BRANCH_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BRANCH>()
                .Property(e => e.BRANCH_LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<BRANCH>()
                .HasMany(e => e.INVENTORies)
                .WithRequired(e => e.BRANCH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.BOOK_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUBLISHER>()
                .Property(e => e.PUBLISHER_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUBLISHER>()
                .Property(e => e.PUBLISHER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PUBLISHER>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<WROTE>()
                .Property(e => e.BOOK_CODE)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
