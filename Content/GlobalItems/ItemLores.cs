using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using System.Linq;
using System.Collections.Generic;

namespace VanillaAdditions.Content.ItemLore
{
    public class ItemLore : GlobalItem
    {
        /*public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.BrokenHeroSword) ;
            item.SetNameOverride("Japanese long sword");
        }*/
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.BrokenHeroSword)
                tooltips[1].Text = tooltips[1].Text + "\nA remnant of its former self, telling a tale of a sword that has seen better days.";
        }
    }
}