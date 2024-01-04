using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Publisher;

namespace Bookshelf.Infra.Persistence.Entities.Book;

[Table("Book")]
public class BookE
{
    [Key]
    public long Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Language { get; set; } = string.Empty;
    [Required]
    public DateTime PublicationDate { get; set; }
    
    [Required]
    public int CapeType { get; set; }

    [Required]
    public string Isbn { get; set; } = string.Empty;
    [Required]
    public string Sinopse { get; set; } = string.Empty;
    [Required]
    public string Edition { get; set; } = string.Empty;
    [Required]
    public int NumberPages { get; set; }
    [Required]
    public string Cape { get; set; } = string.Empty;
    [Required]
    [ForeignKey("Publisher")]
    public long PublisherId { get; set; }
    public PublisherE Publisher { get; set; }
}