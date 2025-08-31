using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateBooksDbScript.DB.Models;

namespace CreateBooksDbScript.DataBase
{
    public static class DBManager
    {
        /// <summary>
        /// Запрашивает автора и выводит все его книги в консоль.
        /// </summary>
        public static void PrintAllBooksByAuthor(AppDbContext appDbContext)
        {
            var autorService = new DataBase.Services.AutorService(appDbContext);
            var autors = autorService.GetAllAutors();
            AutorModel autor = null;

            foreach (var item in autors)
            {
                Console.WriteLine($"{item.Id}. {item.Surname} {item.Name} {item.Patronymic}");
            }

            Console.Write("Ввведите номер автора:");
            while (true)
            {
                var input = Console.ReadLine();
                if (!int.TryParse(input, out int number) || !autors.Any(x => x.Id == number))
                {
                    Console.Write("Введите корректный номер автора:");
                    continue;
                }

                autor = autors.First(x => x.Id == number);
                break;
            }

            var bookService = new DataBase.Services.BookService(appDbContext);
            var books = bookService.GetAllBooksOfAutor(autor);
            if (books.Count == 0)
            {
                Console.WriteLine("У данного автора нет ни одной книги!");
            }
            else
            {
                Console.WriteLine("Найденные книги автора:");
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Id}. {book.Name} - {book.PrintRun}");
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Запрашивает издательство и выводит все его книги в консоль.
        /// </summary>
        public static void PrintAllBooksByPublishingHouse(AppDbContext appDbContext)
        {
            var publishingHouseService = new DataBase.Services.PublishingCompanyService(appDbContext);
            var publishingHouses = publishingHouseService.GetAllPublishingHouses();

            PublishingCompanyModel publishingHouse = null;

            foreach (var item in publishingHouses)
            {
                Console.WriteLine($"{item.Id}. {item.Name} ");
            }

            Console.Write("Ввведите номер издательства:");
            while (true)
            {
                var input = Console.ReadLine();
                if (!int.TryParse(input, out int number) || !publishingHouses.Any(x => x.Id == number))
                {
                    Console.Write("Введите корректный номер издательсва:");
                    continue;
                }

                publishingHouse = publishingHouses.First(x => x.Id == number);
                break;
            }

            var bookService = new DataBase.Services.BookService(appDbContext);
            var books = bookService.GetAllBooksOfPublishingHouse(publishingHouse);
            if (books.Count == 0)
            {
                Console.WriteLine("У данного издательства нет ни одной книги!");
            }
            else
            {
                Console.WriteLine("Найденные книги издательства:");
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Id}. {book.Name} - {book.PrintRun}");
                }
            }
            Console.WriteLine();
        }
    }
}
