using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace VanillaAdditions.Content.GlobalItems
{
    public class PlatformSpeedPLacements : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.WoodPlatform)
            {
                Item.useAnimation = 2;
                Item.useTime = 2;
            }
        }
    }
}