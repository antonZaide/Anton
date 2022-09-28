using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anton.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Anton.Models;

namespace Anton.Areas.Identity.Data;

public class AntonContextDb : IdentityDbContext<AntonUser>
{
    public AntonContextDb(DbContextOptions<AntonContextDb> options): base(options)
    {
    }

    public DbSet<Company> Companies  { get; set; }

    public DbSet<Artist> Artists  { get; set; }

    public DbSet<Song> Songs  { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Song>().ToTable("Song");
        modelBuilder.Entity<Artist>().ToTable("Artist");
        modelBuilder.Entity<Company>().ToTable("Company");
    }
}

