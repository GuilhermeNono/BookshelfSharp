namespace Bookshelf.Infra.Persistence.Entities.Base;

public class BaseEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}