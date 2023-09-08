using System.ComponentModel.DataAnnotations;

namespace StackOverflow.Data.Models;

public class User
{
    public int Id { get; set; }

    [StringLength(40)]
    public string DisplayName { get; set; }
    public string? AboutMe { get; set; }

    [StringLength(40)]
    public string? EmailHash { get; set; }

    [StringLength(100)]
    public string? Location { get; set; }
    public int? Age { get; set; }
    public int DownVotes { get; set; }
    public int UpVotes { get; set; }
    public int Reputation { get; set; }
    public int Views { get; set; }

    [StringLength(200)]
    public string? WebsiteUrl { get; set; }
    public int? AccountId { get; set; }
    public DateTime LastAccessDate { get; set; }
    public DateTime CreationDate { get; set; }
}
