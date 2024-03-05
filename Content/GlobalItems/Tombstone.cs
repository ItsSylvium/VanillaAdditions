/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace VanillaAdditions.Content.GlobalItems
{
    public class MyGlobalTile : GlobalTile
    {
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (!noItem && type == TileID.Tombstones)
            {
                if (Main.rand.NextBool(1)); // Give every tile a 1/1 chance to drop an item.
                {
                    Item.NewItem(int x, int y, 16 , 16, 16, ItemType<Items.Tombstone0>());
                    noItem = true; // Prevent any further items from dropping (if you like).
                }
            }
        }
    }
}
*/