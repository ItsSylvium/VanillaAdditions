using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanillaAdditions.Common.Recipes
{
    public class RecipePlus : ModSystem
    {
        public override void AddRecipes() //could make it use a material type
        {
            Recipe recipe = Recipe.Create(ItemID.BabyBirdStaff, 1);
            recipe.AddIngredient(ItemID.Wood, 8);
            recipe.AddIngredient(ItemID.Hay, 14);
            recipe.AddRecipeGroup("Bird");
            recipe.Register(); // When you're done, call this to register the recipe.

            recipe = Recipe.Create(ItemID.MushroomGrassSeeds, 2);
            recipe.AddIngredient(ItemID.GlowingMushroom, 1);
            recipe.Register();
        }
    }
}
