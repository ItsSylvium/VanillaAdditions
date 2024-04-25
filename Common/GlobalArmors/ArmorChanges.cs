using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanillaAdditions.Common.GlobalArmor
{
    public class ArmorChanges : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (player.head == 81 || player.body == 52)
            {
                if (Main.IsItRaining == true)
                {
                    player.fishingSkill += 10;
                }
                else
                {
                    player.fishingSkill += 5;
                }
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            int[] rainCoatItems = { ItemID.RainCoat, 1135 };
            if (item.type == rainCoatItems[0] || item.type == rainCoatItems[1])
            {
                tooltips[1].Text = tooltips[1].Text + "\nIncreases fishing power by 5, doubled while raining";
            }
        }
    }
}
