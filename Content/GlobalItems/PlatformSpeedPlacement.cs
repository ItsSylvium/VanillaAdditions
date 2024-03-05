using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using System.Linq;

namespace VanillaAdditions.Content.GlobalItems
{
    public class PlatformSpeedPLacements : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            int[] array = new int[] { 94, 632, 633, 913, 1385, 1457, 1702, 1818, 2518, 2566, 2581, 2628, 2629, 2822, 3144, 3145, 3146, 3903, 3905, 3906, 3907, 3908, 3945, 3957, 4159, 4180, 4201, 4222, 4311, 4416, 5162, 5292, };
            if (array.Contains(item.type))
            {
                item.useAnimation = 3;
                item.useTime = 3;
            }
        }
    }
}