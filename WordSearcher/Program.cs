namespace WordSearcher
{
  /// <summary>
  /// Класс запуска программы.
  /// </summary>
  internal class Program
  {
    static async Task Main(string[] args)
    {
      while (true)
      {
        string path = FolderFinder.GetFolderPath();

        if (!FolderFinder.CheckFolderPath(path))
        {
          continue;
        }

        var files = FolderFinder.GetFilesFromFolder(path);
        if (files == null)
        {
          continue;
        }

        string findedWord = WordFinder.GetFindedWord();

        await SearchManager.SearchWordsInFiles(path, files, findedWord);
      }
    }
  }
}
