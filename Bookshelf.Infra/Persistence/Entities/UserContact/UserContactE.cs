using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Base;
using Bookshelf.Infra.Persistence.Entities.UserAccount;
using Bookshelf.Infra.Persistence.Entities.UserContactType;

namespace Bookshelf.Infra.Persistence.Entities.UserContact;

[Table("UserContact")]
public class UserContactE: BaseEntity
{
    [Key]
    public long Id { get; set; }

    public bool Active { get; set; }
    public string Contact { get; set; } = string.Empty;

    [ForeignKey("UserAccount")]
    public long UserAccountId { get; set; }
    public UserAccountE UserAccount { get; set; }
    
    [ForeignKey("UserContactType")] 
    public long UserContactTypeId { get; set; }
    public UserContactTypeE UserContactType { get; set; }
}