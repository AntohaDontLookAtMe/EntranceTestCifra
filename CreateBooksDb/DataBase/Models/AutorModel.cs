using System.ComponentModel.DataAnnotations;

namespace CreateBooksDbScript.DB.Models
{
  /// <summary>
  /// Модель автора книги.
  /// </summary>
  public class AutorModel
  {
    /// <summary>
    /// Уникальный идентификатор автора.  
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Имя автора.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Фамилия автора.
    /// </summary>
    public string Surname { get; set; } = string.Empty;

    /// <summary>
    /// Отчество автора.
    /// </summary>
    public string Patronymic { get; set; } = string.Empty;

    /// <summary>
    /// Год рождения автора.
    /// </summary>
    public int YearOfBirth { get; set; }
  }
}
