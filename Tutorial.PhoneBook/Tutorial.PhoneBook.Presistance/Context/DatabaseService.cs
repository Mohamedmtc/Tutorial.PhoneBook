using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tutorial.PhoneBook.Application.Contracts;
using Tutorial.PhoneBook.Domain.Entities;

namespace Tutorial.PhoneBook.Presistance.Context;

public partial class DatabaseService : DbContext, IDataBaseService
{
    public DatabaseService()
    {
    }

    public DatabaseService(DbContextOptions<DatabaseService> options)
        : base(options)
    {
    }

    public virtual DbSet<PhoneNumberTypes> PhoneNumberTypes { get; set; }

    public virtual DbSet<PhoneNumbers> PhoneNumbers { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Initial Catalog=SQlDBPhoneBook;Integrated Security=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PhoneNumberTypes>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PhoneNumbers>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
