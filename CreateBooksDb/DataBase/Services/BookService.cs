using CreateBooksDbScript.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBooksDbScript.DataBase.Services
{
  /// <summary>
  /// Класс для управления данными книг.
  /// </summary>
  public class BookService
  {
    /// <summary>
    /// Класс для управления БД.
    /// </summary>
    private readonly AppDbContext _context;

    public BookService(AppDbContext context)
    {
      _context = context;
    }

    /// <summary>
    /// Получает все книги из базы данных.
    /// </summary>
    /// <returns>Список книг.</returns>
    public List<BookModel> GetAllBooks() => _context.Books.ToList();

    /// <summary>
    /// Получает все книги из базы данных по определённому автору.
    /// </summary>
    /// <returns>Список книг.</returns>
    public List<BookModel> GetAllBooksOfAutor(AutorModel autorModel) => _context.Books.Where(b => b.AuthorId == autorModel.Id).ToList();

    /// <summary>
    /// Получает все книги из базы данных по определённому издательсву.
    /// </summary>
    /// <returns>Список книг.</returns>
    public List<BookModel> GetAllBooksOfPublishingHouse(PublishingCompanyModel publishingHouseModel) => _context.Books.Where(b => b.PublishingHouseId == publishingHouseModel.Id).ToList();
  }
}
