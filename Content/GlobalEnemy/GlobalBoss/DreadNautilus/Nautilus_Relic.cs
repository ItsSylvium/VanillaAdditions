﻿using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using VanillaAdditions.Content.GlobalEnemy.GlobalBoss.DreadNautilus;

namespace VanillaAdditions.Content.GlobalEnemy.GlobalBoss.DreadNautilus
{
    public class Nautilus_Relic : ModItem
    {
        public override string Texture => "VanillaAdditions/Assets/Boss/DreadNautilus/Nautilus_Relic";
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.maxStack = 99;
            Item.width = 34;
            Item.height = 42;
            Item.master = true;
            Item.value = Item.buyPrice(0, 2); //2 gold?

            Item.DefaultToPlaceableTile(ModContent.TileType<GlobalEnemy.GlobalBoss.DreadNautilus.Nautilus_Relic_Tile>(), 0);
        }
    }
}
