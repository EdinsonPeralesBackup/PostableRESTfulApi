using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostableRESTfulApi.Models.DTOs.Post;

namespace PostableRESTfulApi.Models.Configurations
{
  public class PostConfig : IEntityTypeConfiguration<Post>
  {
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasData(
          new CreatePostDto { Id = 1, Content = "Post para crear una página web. Bienvenidos!!! en este post veremos los pasos para crear una página web", UserId = 1}
        );
    }
  }
}
