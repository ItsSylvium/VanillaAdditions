using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria;

namespace VanillaAdditions.Content.Buffs
{
	public class Destroyer_Rage : ModBuff
    {
        public override string Texture => "VanillaAdditions/Assets/Buffs/Destroyer_Rage";

        public override void Update(Player player, ref int buffIndex)
        {
            //player
        }
        // create a red glow on the players eyes while active
    }
}