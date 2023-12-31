﻿using Microsoft.EntityFrameworkCore;
using KirillovaAnnaKt_42_20.Models;
using KirillovaAnnaKt_42_20.Database.Configurations;

namespace KirillovaAnnaKt_42_20.Database
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
        }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
    }
}
