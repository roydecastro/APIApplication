using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApplication.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        [Display(Name = "Product Name")]
        [Remote("IsProductUnique", "Product", HttpMethod = "POST", ErrorMessage = "Product with the same Name, Color, Price, Category, and Factory already exists.")]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Color is required.")] 
        public string? Color { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Price must be a non-negative value.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Image URL is required.")]
        public string? Image { get; set; }

        [Required(ErrorMessage = "Category ID is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Factory ID is required.")]
        public int FactoryId { get; set; }
    }
}
