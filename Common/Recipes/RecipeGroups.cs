using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
namespace VanillaAdditions.Common.Recipes
{
    public class RecipeGroups : ModSystem
    {
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Fish", new int[]
            {
                ItemID.Cardinal,
                ItemID.BlueJay,
                ItemID.Bird

            });
            RecipeGroup.RegisterGroup("Bird", group);
        }
    }
}
