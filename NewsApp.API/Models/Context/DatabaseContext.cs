using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NewsApp.API.Models.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("NewsDbConnection") { }

        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<News>().HasKey(p => p.newsID);

            modelBuilder.Entity<News>()
                        .Property(p => p.newsID)
                        .HasColumnName("NewsID")
                        .HasColumnType("bigint")
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<News>()
                        .Property(p => p.title)
                        .HasMaxLength(256)
                        .IsRequired()
                        .HasColumnName("Title")
                        .HasColumnType("nvarchar");

            modelBuilder.Entity<News>()
                        .Property(p => p.content)
                        .IsRequired()
                        .HasColumnName("Content")
                        .HasColumnType("text");

            modelBuilder.Entity<News>()
                        .Property(p => p.imgURL)
                        .HasMaxLength(256)
                        .HasColumnName("ImageUrl")
                        .HasColumnType("varchar")
                        .IsRequired();
            
            modelBuilder.Entity<News>()
                        .Property(p => p.publishedDate)
                        .HasColumnType("Datetime")
                        .HasColumnName("PublishedDate")
                        .IsRequired();
        }

    }
}