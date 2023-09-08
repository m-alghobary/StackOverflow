using System.ComponentModel.DataAnnotations;

namespace StackOverflow.Data.Models;

public class Badge
{
    public int Id { get; set; }

    [StringLength(40)]
    public string Name { get; set; }
    public int UserId { get; set; }
    public DateTime Date { get; set; }

    public User User { get; set; }
}
