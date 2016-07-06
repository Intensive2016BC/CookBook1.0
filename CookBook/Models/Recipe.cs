using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CookBook.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int Points { get; set; }
        public int CategoryId { get; set; }

        public Recipe(int id, Image image, string name, List<string> ingredients, string description, int lvl,
            int points, int catId)
        {
            Id = id;
            Image = image;
            Name = name;
            Ingredients = ingredients;
            Description = description;
            Level = lvl;
            Points = points;
            CategoryId = catId;
        }

    }
}
