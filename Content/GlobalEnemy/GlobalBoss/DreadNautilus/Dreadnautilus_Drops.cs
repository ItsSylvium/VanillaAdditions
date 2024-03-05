using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace VanillaAdditions.Content.GlobalEnemy.GlobalBoss.DreadNautilus
{
    public class Dreadnautilus_Drops : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.BloodNautilus)
            {
                //Player player = Player.
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotExpert(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.DreadNautilus_Trophy_Item>()));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsExpert(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.DreadNautilus_Trophy_Item>()));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.DreadNautilus_Trophy_Item>()));

                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<Content.GlobalEnemy.GlobalBoss.DreadNautilus.Nautilus_Relic>()));

                npcLoot.Add(ItemDropRule.MasterModeDropOnAllPlayers(ModContent.ItemType<DreadConchItem>(), 4));//given to players on boss kill with 1/4 chance
            }
        }
        /*public override void OnKill(NPC npc)
        {
            if (npc.type == NPCID.BloodNautilus)    ******> Probably will need to check if the boss was killed then spawn item on players <*********
            {

            }
        }*/
    }
}
