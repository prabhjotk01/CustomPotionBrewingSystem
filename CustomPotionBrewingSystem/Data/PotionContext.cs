
using Microsoft.EntityFrameworkCore;
using CustomPotionBrewingSystem.Models;

namespace CustomPotionBrewingSystem.Data
{
    public class PotionContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<BrewedPotion> BrewedPotions { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=potions.db");
        }
    }
}
