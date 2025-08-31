using System.ComponentModel.DataAnnotations;

namespace CreateBooksDbScript.DB.Models
{
  /// <summary>
  /// Модель книги.
  /// </summary>
  public class BookModel
  {
    /// <summary>
    /// Уникальный идентификатор книги.
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Наименование книги.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Тираж книги.
    /// </summary>
    public int PrintRun { get; set; }

    /// <summary>
    /// Уникальный идентификатор автора книги.
    /// </summary>
    public int AuthorId { get; set; }

    /// <summary>
    /// Уникальный идентификатор издательства книги.
    /// </summary>
    public int PublishingHouseId { get; set; }
  }
}
