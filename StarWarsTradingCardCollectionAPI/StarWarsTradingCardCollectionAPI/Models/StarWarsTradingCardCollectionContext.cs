using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class StarWarsTradingCardCollectionContext : DbContext
    {
        public StarWarsTradingCardCollectionContext()
        {
        }

        public StarWarsTradingCardCollectionContext(DbContextOptions<StarWarsTradingCardCollectionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCard> UserCard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Card", "Cards");

                entity.HasIndex(e => new { e.CardNo, e.SeriesId })
                    .HasName("uq_Card")
                    .IsUnique();

                entity.Property(e => e.CardName).HasMaxLength(100);

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.Card)
                    .HasForeignKey(d => d.SeriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Card_Series");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.ToTable("Series", "Cards");

                entity.Property(e => e.SeriesName).HasMaxLength(100);

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_Series_Set");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set", "Cards");

                entity.Property(e => e.SetName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "Users");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(320);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserCard>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CardId });

                entity.ToTable("UserCard", "Users");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.UserCard)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCard_Card");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCard)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCard_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
