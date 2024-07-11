using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PostableRESTfulApi.Models.DTOs.User
{
  public class CreateUserDto
  {
    public int? Id { get; set; }
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Role { get; set; } = "User";
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
  }
}
