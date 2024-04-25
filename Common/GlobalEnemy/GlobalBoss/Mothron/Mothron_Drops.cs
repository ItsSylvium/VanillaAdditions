/*using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace VanillaAdditions.Common.GlobalEnemy.GlobalBoss.Mothron
{
    public class Mothron_Drops : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Mothron)
            {
                npcLoot.Add(ItemDropRule.MasterModeDropOnAllPlayers(ModContent.ItemType<MothronBabyItem>(), 4));
            }
        }//            ************ Make it drop on player (alt go through boss on kill) *************
    }
}
*/