using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.BookCopy;
using Bookshelf.Infra.Persistence.Entities.UserLibrary;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.Infra.Persistence.Entities.Borrowing;

[Table("Borrowing")]
public class BorrowingE
{
    [Key]
    public long Id { get; set; }

    public DateTime LoanDate { get; set; }
    public DateTime RenewalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public bool Active { get; set; }
    public bool Overdue { get; set; }

    [ForeignKey("BookCopy")]
    public long BookCopyId { get; set; }
    public BookCopyE BookCopy { get; set; }
    
    [ForeignKey("UserLibrary")]
    public long UserLibraryId { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public UserLibraryE UserLibrary { get; set; }
}