namespace WordSearcher
{
  /// <summary>
  /// Класс для работы с папками.
  /// </summary>
  public static class FolderFinder
  {
    #region Методы

    /// <summary>
    /// Запрашивает у пользователя путь к папке с файлами.
    /// </summary>
    /// <returns>Путь к папке.</returns>
    public static string GetFolderPath()
    {
      Console.Write("Введите полный путь к папке с файлами: ");
      return Console.ReadLine();
    }

    /// <summary>
    /// Проверяет существование папки по указанному пути.
    /// </summary>
    /// <param name="path">Путь к файлу.</param>
    /// <returns>true - папка существует, false - папки нет.</returns>
    public static bool CheckFolderPath(string path)
    {
      if (!Directory.Exists(path))
      {
        Console.WriteLine($"Папка с путём {path} не существует.\n");
        return false;
      }

      return true;
    }

    /// <summary>
    /// Возвращает наличие файлов в папке и список файлов в ней.
    /// </summary>
    /// <param name="path">Путь к папке.</param>
    /// <returns>
    /// null,если в папке не оказалось файлов
    /// Иначе пути к каждому файлу из папки.
    /// </returns>
    public static List<string> GetFilesFromFolder(string path)
    {
      var files = Directory.GetFiles(path).ToList();
      if (files.Count == 0)
      {
        Console.WriteLine($"В папке {path} нет файлов.\n");
        return null;
      }

      return files;
    }

     #endregion

  }
}
