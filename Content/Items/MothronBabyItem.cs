using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using VanillaAdditions.Content.Buffs;
using VanillaAdditions.Content.Proj.Pets;
using Microsoft.Xna.Framework;

namespace VanillaAdditions.Content.Items
{
    public class MothronBabyItem : ModItem
    {
        public override string Texture => "VanillaAdditions/Assests/Items/MothronBabyItem";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sun Bleached Cocoon");
            Tooltip.SetDefault("Summons a creature of the black sun"); 

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; //for journey mode
        }
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 18;
            Item.rare = -13; //Rainbow/Expert mode
            Item.shoot = ModContent.ProjectileType<MothronBabyProj>();
            Item.buffType = ModContent.BuffType<MothronBabyBuff>();
        }
        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(Item.buffType, 3600);
            }
        }
    }
}
