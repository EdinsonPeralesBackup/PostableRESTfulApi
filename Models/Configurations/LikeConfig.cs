using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PostableRESTfulApi.Models.Configurations
{
  public class LikeConfig : IEntityTypeConfiguration<Like>
  {
    public void Configure(EntityTypeBuilder<Like> builder)
    {        
        builder.HasOne(p => p.User)
            .WithMany(u => u.Likes)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(p => p.Post)
            .WithMany(u => u.Likes)
            .HasForeignKey(p => p.PostId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasIndex(l => new { l.PostId, l.UserId }).IsUnique();
    }
  }
}
