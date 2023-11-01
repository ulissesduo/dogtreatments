using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FoodControl.Models;

public partial class DogFoodContext : DbContext
{
    public DogFoodContext()
    {
    }

    public DogFoodContext(DbContextOptions<DogFoodContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Treatment> Treatments { get; set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlite("Data Source=./Database/FoodDog.db");
            => optionsBuilder.UseSqlite(@"Data Source=C:\Users\uliss\Downloads\sqlitedog\FoodDog.db");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
