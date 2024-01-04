using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.UserProfile;

namespace Bookshelf.Infra.Persistence.Entities.UserAccount;

[Table("UserAccount")]
public class UserAccountE
{
    [Key] 
    public long Id { get; set; }

    public string PersonName { get; set; } = string.Empty;
    public bool Active { get; set; }
    public DateTime BirthDate { get; set; }
    public string Cpf { get; set; } = string.Empty;

    //TODO 28-12-2023 | 15:33: Transformar em uma entidade
    public string Gender { get; set; } = string.Empty;

    [ForeignKey("UserProfile")]
    public long UserProfileId { get; set; }
    public UserProfileE UserProfile { get; set; }
}