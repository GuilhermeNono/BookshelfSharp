using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Book;
using Bookshelf.Infra.Persistence.Entities.Category;

namespace Bookshelf.Infra.Persistence.Entities.BookCategory;

[Table("BookCategory")]
public class BookCategoryE
{
    [Key]
    public long Id { get; set; }

    [ForeignKey("Category")]
    public long CategoryId { get; set; }
    public CategoryE Category { get; set; }

    [ForeignKey("Book")]
    public long BookId { get; set; }
    public BookE Book { get; set; }
}