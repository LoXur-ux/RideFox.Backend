using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;

namespace RideFox.Domain;

/// <summary>
/// Базовый класс, описывающий структуру всех пользователей ИС (Client, Staff)
/// </summary>
[Table("Person")]
public class Person : BaseEntity
{
    #region Fields

    [Required] public string Login { get; set; }
    [Required] public string Password { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string PhoneNumber { get; set; }
    [Required] public DateTime DateOfRegister { get; set; } = DateTime.Now;
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    public string MiddleName { get; set; }
    [Required] public DateTime Birthday { get; set; }

    #endregion
}
