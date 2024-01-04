using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Base;
using Bookshelf.Infra.Persistence.Entities.UserAccount;

namespace Bookshelf.Infra.Persistence.Entities.Password;

[Table("Password")]
public class PasswordE: BaseEntity
{
    public long Id { get; set; }
    public bool Active { get; set; }
    public string LoginHash { get; set; } = string.Empty;

    [ForeignKey("UserAccount")]
    public long UserAccountId { get; set; }
    public UserAccountE UserAccount { get; set; }
}