using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using VanillaAdditions.Common.GlobalEnemy.GlobalBoss.DreadNautilus;
using Terraria.DataStructures;
using VanillaAdditions.Common.GlobalEnemy.GlobalBoss.Mothron;

namespace VanillaAdditions.Common.GlobalEnemy.GlobalBoss
{
    public class NPCDropAddittions : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.BloodNautilus)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DreadNautilus_Trophy_Item>(), 1, 1, 1));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsMasterMode(), ModContent.ItemType<Nautilus_Relic>()));
            }
        }
        public override void OnKill(NPC npc)
        {
            Random rand = new();

            if (npc.type == NPCID.BloodNautilus && Main.masterMode == true)
            {
                foreach (Player player in Main.player)
                {
                    IEntitySource source = player as IEntitySource;

                    int roll = rand.Next(4);
                    if (roll == 3)
                    {
                        player.QuickSpawnItem(source, ModContent.ItemType<DreadConchItem>(), 1);
                    }
                }
            }
            if (npc.type == NPCID.Mothron && Main.masterMode == true)
            {
                foreach (Player player in Main.player)
                {
                    IEntitySource source = player as IEntitySource;

                    int roll = rand.Next(4);
                    if (roll == 3)
                    {
                        player.QuickSpawnItem(source, ModContent.ItemType<MothronBabyItem>(), 1);
                    }
                }
            }
        }
    }
}
