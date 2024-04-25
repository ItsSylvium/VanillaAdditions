using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Security.Principal;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace VanillaAdditions.Common.GlobalTiles
{
    public class NatureGift_Light : GlobalTile
    {
        public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];


            if (TileID.JunglePlants == type && tile.TileFrameX == 162) 
            {
                Main.tileLighted[type] = true;

                r = 0.1f; g = 0.4f; b = 0.8f;
            }
        }
    }
}
