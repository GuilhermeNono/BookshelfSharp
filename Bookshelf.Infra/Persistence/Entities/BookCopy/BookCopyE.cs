using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Base;
using Bookshelf.Infra.Persistence.Entities.Book;
using Bookshelf.Infra.Persistence.Entities.Library;

namespace Bookshelf.Infra.Persistence.Entities.BookCopy;

[Table("BookCopy")]
public class BookCopyE: BaseEntity
{
    [Key] 
    public long Id { get; set; }

    public string Code { get; set; } = string.Empty;
    public bool Active { get; set; }
    
    [ForeignKey("Book")] 
    public long BookId { get; set; }
    public BookE Book { get; set; }
    
    [ForeignKey("Library")] 
    public long LibraryId { get; set; }
    public LibraryE Library { get; set; }
    
}