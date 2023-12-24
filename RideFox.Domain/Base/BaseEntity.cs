using System.ComponentModel.DataAnnotations;

namespace RideFox.Domain.Base;
public abstract class BaseEntity
{
    [Key] public Guid Id { get; set; }
}
