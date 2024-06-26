﻿using System;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanillaAdditions.Common.GlobalEnemy.GlobalBoss.DreadNautilus
{
    public class DreadNautilus_Trophy_Item : ModItem
    {
        public override string Texture => "VanillaAdditions/Assets/Boss/DreadNautilus/DreadNautilus_Trophy_Item";
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; //for journey mode
        }
        public override void SetDefaults() //Fix the rarity to fit trophies
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<DreadNautilus.DreadNautilus_Trophy_Tile>());

            Item.rare = 1;
            Item.maxStack = 99;
            Item.width = 32;
            Item.height = 32;
            Item.consumable = true;
        }
    }
}
