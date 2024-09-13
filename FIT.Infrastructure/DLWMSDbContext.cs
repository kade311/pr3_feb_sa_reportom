﻿using FIT.Data;
using FIT.Data.Ispit;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Prostorije> Prostorije { get; set; }
        public DbSet<Nastava> Nastava { get; set; }
        public DbSet<Prisustvo> Prisustvo { get; set; }
        public DbSet<Predmeti> Predmeti { get; set; }
    }
}