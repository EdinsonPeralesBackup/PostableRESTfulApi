using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PostableRESTfulApi.Models.Configurations
{
  public class LikeConfig : IEntityTypeConfiguration<Like>
  {
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        // builder.HasIndex(l => new { l.PostId, l.UserId }).IsUnique();
    }
  }
}
