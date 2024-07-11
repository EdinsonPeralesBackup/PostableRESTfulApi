using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PostableRESTfulApi.Models.DTOs.Post
{
  public class CreatePostDto
  {
    public int? Id { get; set; }
    public required string Content { get; set; }
    public required int UserId { get;set; }
  }
}
