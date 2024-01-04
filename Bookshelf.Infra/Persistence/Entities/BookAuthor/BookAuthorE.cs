using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Author;
using Bookshelf.Infra.Persistence.Entities.Book;

namespace Bookshelf.Infra.Persistence.Entities.BookAuthor;

[Table("BookAuthor")]
public class BookAuthorE
{
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey("Author")]
    public long AuthorId { get; set; }
    public AuthorE Author { get; set; }

    [Required]
    [ForeignKey("Book")]
    public long BookId { get; set; }
    public BookE Book { get; set; }
}