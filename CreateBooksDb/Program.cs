using CreateBooksDbScript.DataBase;
using CreateBooksDbScript.DB.Models;

namespace CreateBooksDbScript
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var dbContext = new AppDbContext();
      Console.WriteLine($"Путь к базе данных:{AppDbContext.DbPath}");

      while (true)
      {
        Console.WriteLine("1. Отобразить книги по автору");
        Console.WriteLine("2. Отобразить книги по издательству");
        Console.WriteLine("0. Выход");
        Console.Write("Введите номер пункта:");
        var input = Console.ReadLine();
        switch (input)
        {
          case "1":
            DBManager.PrintAllBooksByAuthor(dbContext);
            break;

          case "2":
            DBManager.PrintAllBooksByPublishingHouse(dbContext);
            break;

          case "0":
            return;

          default:
            break;
        }
      }
    }
  }
}
