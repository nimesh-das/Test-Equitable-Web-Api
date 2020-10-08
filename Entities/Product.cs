using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProductAPI.Entities
{
     public class Product
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int Id { get; set; }
          [Required]
          [MaxLength(100)]
          public string Name { get; set; }
          [Required]
          public string Type { get; set; }
     }
}