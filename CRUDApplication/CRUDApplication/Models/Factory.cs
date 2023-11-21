using System.ComponentModel.DataAnnotations;
namespace CRUDApplication.Models
{
    public class Factory
    {
        [Key] 
        public int FactoryId { get; set; }
        [Required]
        [Display(Name = "Factory Name")]
        public string? FactoryName { get; set; }
    }
}
