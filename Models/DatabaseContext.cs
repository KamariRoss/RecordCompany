using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RecordCompany.Models
{
  public partial class DatabaseContext : DbContext
  {
    public DbSet<Band> Band { get; set; }
    public DbSet<Album> Album { get; set; }
    public DbSet<Song> Song { get; set; }

    // Add Database tables here
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
// #error Make sure to update the connection string to the correct database
        optionsBuilder.UseNpgsql("server=localhost;database=RecordCompany");
      }
    }
  }
}
