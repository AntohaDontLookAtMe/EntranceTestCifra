using CreateBooksDbScript.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace CreateBooksDbScript.DataBase
{
  /// <summary>
  /// Настрйока и подлючение к БД.
  /// </summary>
  public class AppDbContext : DbContext
  {
    /// <summary>
    /// Таблица книг.
    /// </summary>
    public DbSet<BookModel> Books => Set<BookModel>();

    /// <summary>
    /// Таблица авторов.
    /// </summary>
    public DbSet<AutorModel> Authors => Set<AutorModel>();

    /// <summary>
    /// Таблица издательств.
    /// </summary>
    public DbSet<PublishingCompanyModel> PublishingCompany => Set<PublishingCompanyModel>();

    /// <summary>
    /// Путь к БД.
    /// </summary>
    public static readonly string DbPath = Path.Combine(AppContext.BaseDirectory, "books.db");

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

    public AppDbContext()
    {
      Database.EnsureCreated();
    }
  }
}
