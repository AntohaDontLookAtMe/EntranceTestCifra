using CreateBooksDbScript.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBooksDbScript.DataBase.Services
{
  public class PublishingCompanyService
  {
    /// <summary>
    /// Класс для управления БД.
    /// </summary>
    private readonly AppDbContext _context;

    public PublishingCompanyService(AppDbContext context)
    {
      _context = context;
    }

    /// <summary>
    /// Получает все издательства из базы данных.
    /// </summary>
    /// <returns>Список авторов.</returns>
    public List<PublishingCompanyModel> GetAllPublishingHouses() => _context.PublishingCompany.ToList();
  }
}
