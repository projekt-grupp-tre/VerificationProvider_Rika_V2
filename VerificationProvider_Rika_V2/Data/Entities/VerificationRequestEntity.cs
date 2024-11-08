
using System.ComponentModel.DataAnnotations;

namespace VerificationProvider_Rika_V2.Data.Entities;

public class VerificationRequestEntity
{
    [Key]
    public string Email { get; set; } = null!;
    public string Code { get; set; } = null!;
    public DateTime ExpiryDate { get; set; } = DateTime.Now.AddMinutes(5);
}
