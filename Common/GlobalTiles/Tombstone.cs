using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using VanillaAdditions.Content.Items;
using static Terraria.ModLoader.ModContent;

namespace VanillaAdditions.Common.GlobalTiles
{
    public class MyGlobalTile : GlobalTile
    {
        public override bool CanDrop(int i, int j, int type)
        {
            if (type == TileID.Tombstones)
            {
                int x = i * 16; int y = j * 16;

                Item.NewItem(
                    WorldGen.GetItemSource_FromTileBreak(i, j), 
                    new Rectangle(x, y, 16, 16), 
                    ModContent.ItemType<Tombstone0>(), 1);

                return false;
            }
            return true;
        }
    }
}
