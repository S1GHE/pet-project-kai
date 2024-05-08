using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KaiDns.Domain.Model;

public partial class Db4660Context : DbContext
{
    public Db4660Context()
    {
    }

    public Db4660Context(DbContextOptions<Db4660Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Catalog> Catalogs { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=db4660.public.databaseasp.net;Initial Catalog=db4660;Persist Security Info=True;User ID=db4660;Password=wX@3N+2j-yD4; TrustServerCertificate=True");
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Catalog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalog");

            entity.ToTable("Catalog");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
