namespace WordSearcher
{
    /// <summary>
    /// Класс для задания искомого слова.
    /// </summary>
    public static class WordFinder
    {
      #region Методы

      /// <summary>
      /// Метод для задания искомого слова.
      /// </summary>
      /// <returns>Возваращает искомое слово.</returns>
      internal static string GetFindedWord()
      {
        while (true)
        {
          Console.Write("Введите слово для поиска: ");
          string word = Console.ReadLine();
          if (string.IsNullOrEmpty(word))
          {
            Console.Write("Слово не может быть пустым!\n");
            continue;
          }
          else
          {
            return word;
          }
        }
      }

       #endregion
    }
}
