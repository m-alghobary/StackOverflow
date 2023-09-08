using System.ComponentModel.DataAnnotations;

namespace StackOverflow.Data.Models;

public class Comment
{
    public int Id { get; set; }
    public DateTime CreationDate { get; set; }

    [StringLength(700)]
    public string Text { get; set; }
    public int? UserId { get; set; }
    public int PostId { get; set; }
    public int Score { get; set; }

    public Post Post { get; set; }
    public User? User { get; set; }
}
