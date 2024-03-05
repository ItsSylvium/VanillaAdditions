using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent; //Needs to be dropped by tile and needs a way to make it place any vairiant
using Terraria.ID;

namespace VanillaAdditions.Content.Items
{
	public class Tombstone0 : ModItem
	{
        public override string Texture => "VanillaAdditions/Assets/Items/Tombstone_0";
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 30;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = TileID.Tombstones;
            /*if (Main.rand.NextBool(2))
            {
                Item.placeStyle = 3;
            }
            else
            {
                Item.placeStyle = 2;
            }*/
;
        }
    }
}