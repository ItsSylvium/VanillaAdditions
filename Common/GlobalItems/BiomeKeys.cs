using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.DataStructures;
using VanillaAdditions.Content.Proj.ChestArrows;

namespace VanillaAdditions.Common.GlobalItems
{
    public class BiomeKeys : GlobalItem
    {
        public bool foundDesertChest;
        public bool foundCorruptChest;
        public bool foundBloodChest;
        public bool foundIceChest;
        public bool foundFairyChest;
        public bool foundJungleChest;

        public override bool InstancePerEntity => true;
        public override void UpdateInventory(Item item, Player player)
        {
            if (!player.GetModPlayer<PlayerVariables>().keyFound && !player.dead)
            {
                IEntitySource source = new EntitySource_ItemUse(player, item);

                switch (item.type)
                {
                    case ItemID.DungeonDesertKey:
                        Projectile.NewProjectile
                            (
                            source,
                            player.Center,
                            new Vector2(0, 0),
                            ProjectileType<DesertBiomePoint>(),
                            Damage: 0, KnockBack: 0f
                            );
                        player.GetModPlayer<PlayerVariables>().keyFound = true;
                        break;
                    case ItemID.CorruptionKey:
                        break;
                    case ItemID.CrimsonKey:
                        break;
                    case ItemID.FrozenKey:
                        break;
                    case ItemID.HallowedKey:
                        break;
                    case ItemID.JungleKey:
                        break;
                }
            }
        }
    }
}