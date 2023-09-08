using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflow.Data.Models;

public class PostLink
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int RelatedPostId { get; set; }
    public int LinkTypeId { get; set; }
    public DateTime? CreationDate { get; set; }


    [ForeignKey(nameof(RelatedPostId))]
    public Post RelatedPost { get; set; }

    public Post Post { get; set; }
    public LinkType LinkType { get; set; }
}
