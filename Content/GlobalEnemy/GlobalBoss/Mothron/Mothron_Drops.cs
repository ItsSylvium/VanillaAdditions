using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace VanillaAdditions.Content.GlobalEnemy.GlobalBoss.Mothron
{
    public class Mothron_Drops : GlobalNPC
    {
        public override void ModifyNPCLoot(Terraria.NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Mothron)
            {
                Player player;
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<MothronBabyItem>(), 4));
            }
        }//            ************ Make it drop on player (alt go through boss on kill) *************
    }
}
