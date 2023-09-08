using System.ComponentModel.DataAnnotations;

namespace StackOverflow.Data.Models;

public class PostType
{
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; }
}
