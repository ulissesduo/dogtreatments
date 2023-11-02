using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FoodControl.Models;

public partial class DogtreatmentsContext : DbContext
{
    public DogtreatmentsContext()
    {
    }

    public DogtreatmentsContext(DbContextOptions<DogtreatmentsContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Treatment> Treatments
    {
        get;
        set;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlite(@"Data Source=.\Database\FoodDog.db");
        => optionsBuilder.UseSqlite(@"Data Source=C:\Users\uliss\source\repos\FoodControl\FoodControl\Database\FoodDog.db");



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
