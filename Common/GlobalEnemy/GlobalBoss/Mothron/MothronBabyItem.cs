using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;

namespace VanillaAdditions.Common.GlobalEnemy.GlobalBoss.Mothron
{
    public class MothronBabyItem : ModItem
    {
        public override string Texture => "VanillaAdditions/Assets/Boss/Mothron/MothronBabyItem";
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; //for journey mode
        }
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 18;
            Item.rare = -13; //Rainbow/Expert mode
            Item.master = true;
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
