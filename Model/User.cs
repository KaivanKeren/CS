using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS.Model;

public class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; } 
    [Column("name")]
    public string Name { get; set; }
    [Column("age")]
    public int Age { get; set; }


}