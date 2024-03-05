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
            //SUMMONS
            if (item.type == ItemID.GuideVoodooDoll)
                tooltips[1].Text = tooltips[1].Text + "\nd";

            //WEAPONS
            if (item.type == ItemID.ZombieArm)
                tooltips[1].Text = tooltips[1].Text + "\nWhat did you do...";
            if (item.type == ItemID.Excalibur)
                tooltips[1].Text = tooltips[1].Text + "\nThe Excalibur carries an air of mystique and history.";
            if (item.type == ItemID.ShadowFlameHexDoll)
                tooltips[1].Text = tooltips[1].Text + "\nYou can hear faint whispers and giggles emanating from the doll.";

            //TOOLS
            if (item.type == ItemID.BloodFishingRod)
                tooltips[1].Text = tooltips[1].Text + "\nThe angler who wields this ghastly fishing rod must possess a strong stomach.";
            
            //MISC
            if (item.type == ItemID.BrokenHeroSword)
                tooltips[1].Text = tooltips[1].Text + "\nA remnant of its former self, telling a tale of a sword that has seen better days.";
            if (item.type == ItemID.SoulofFright)
                tooltips[1].Text = tooltips[1].Text + "\nThe beholder becomes overwhelmed with a feeling of helplessness and loss of control.";
            if (item.type == ItemID.SoulofMight)
                tooltips[1].Text = tooltips[1].Text + "\nThe beholder is struck with a sense of invincibility and confidence.";
            if (item.type == ItemID.SoulofSight)
                tooltips[1].Text = tooltips[1].Text + "\nThe beholder feels struck with a rush of awe-inspiring sights.";
        }
    }
}