using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HW19_quest
{
    public partial class DBCreatureContext : DbContext
    {
        public DBCreatureContext()
        {
        }

        public DBCreatureContext(DbContextOptions<DBCreatureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ParametrCreature> ParametrCreatures { get; set; }
        public virtual DbSet<TypeCreature> TypeCreatures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding
                //the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148.
                //For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

                optionsBuilder.UseSqlite("Data Source=.\\DataBase\\DBCreature.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParametrCreature>(entity =>
            {
                entity.ToTable("ParametrCreature");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdtypeCreature).HasColumnName("IDTypeCreature");
            });

            modelBuilder.Entity<TypeCreature>(entity =>
            {
                entity.ToTable("TypeCreature");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
