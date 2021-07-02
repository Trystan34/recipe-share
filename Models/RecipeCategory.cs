using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeShare.Models
{
    public class RecipeCategory
    {
        public RecipeCategory()
        {
            Recipes = new HashSet<Recipe>();
        }

        [Key]
        public Guid CategoryId { get; set; }
        [Required]
        [StringLength(300)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
