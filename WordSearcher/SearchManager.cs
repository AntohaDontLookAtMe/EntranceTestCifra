namespace WordSearcher
{
  /// <summary>
  /// Класс-помошник поиска слова по файлам.
  /// </summary>
  public static class SearchManager
  {
    #region Методы

    /// <summary>
    /// Запускает поиск слов по списку файлов и выводит в консоль.
    /// </summary>
    /// <param name="folderpath">Путь к папке с файлами</param>
    /// <param name="files">Список файлов</param>
    /// <param name="word">Искомое слово</param>
    /// <returns></returns>
    public static async Task SearchWordsInFiles(string folderpath, List<string> files, string word)
    {
      var tasks = new List<Task<List<string>>>();
      foreach (var file in files)
      {
        tasks.Add(SearchWordInFile(file, word));
      }

      var results = await Task.WhenAll(tasks);

      var totalFound = results.Sum(r => r.Count);

      Console.WriteLine($"В папке {folderpath} найдено {totalFound} результатов искомого слова\n");

      foreach (var result in results)
      {
        foreach (var item in result)
        {
          Console.WriteLine(item);
        }
      }
    }

    /// <summary>
    /// Поиск заданного слова в файле.
    /// </summary>
    /// <param name="filePath">Путь к файлу </param>
    /// <param name="word">Искомое слово.</param>
    /// <returns>Список результатов.</returns>
    private static async Task<List<string>> SearchWordInFile(string filePath, string word)
    {
      var result = new List<string>();
      int lineNumber = 0;

      try
      {
        using var reader = new StreamReader(filePath);

        string? line;
        while ((line = await reader.ReadLineAsync()) != null)
        {
          lineNumber++;

          if (line.ToLower().Contains(word.ToLower()))
          {
            result.Add($"{filePath}: Найдено слово {word} на строке {lineNumber}");
          }
        }
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Ошибка при обработке файла {filePath}: {ex.Message}");
        Console.ResetColor();
      }

      return result;
    }
      #endregion
  }
}
