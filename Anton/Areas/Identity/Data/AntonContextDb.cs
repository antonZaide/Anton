using Anton.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Anton.Models;

namespace Anton.Areas.Identity.Data;

public class AntonContextDb : IdentityDbContext<AntonUser>
{
    public AntonContextDb(DbContextOptions<AntonContextDb> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<Anton.Models.Artist>? Artist { get; set; }

    public DbSet<Anton.Models.Company>? Company { get; set; }

    public DbSet<Anton.Models.Song>? Song { get; set; }
}
