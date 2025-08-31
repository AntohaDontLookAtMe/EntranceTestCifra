using CreateBooksDbScript.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBooksDbScript.DataBase.Services
{
  /// <summary>
  /// Класс для управления данными авторов.
  /// </summary>
  public class AutorService
  {
    /// <summary>
    /// Класс для управления БД.
    /// </summary>
    private readonly AppDbContext _context;

    public AutorService(AppDbContext context)
    {
      _context = context;
    }

    /// <summary>
    /// Получает всех авторов из базы данных.
    /// </summary>
    /// <returns>Список авторов.</returns>
    public List<AutorModel> GetAllAutors() =>  _context.Authors.ToList();
  }
}
