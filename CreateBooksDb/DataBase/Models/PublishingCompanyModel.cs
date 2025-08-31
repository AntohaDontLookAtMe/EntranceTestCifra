using System.ComponentModel.DataAnnotations;

namespace CreateBooksDbScript.DB.Models
{
  /// <summary>
  /// Модель издателсьва.
  /// </summary>
  public class PublishingCompanyModel
  {
    /// <summary>
    /// Уникальный номер.
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Наимаенование издательства.
    /// </summary>
    public string Name { get; set; } = string.Empty;
  }
}
