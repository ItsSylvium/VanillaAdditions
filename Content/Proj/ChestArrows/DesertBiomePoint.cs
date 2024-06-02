using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using VanillaAdditions.Common;

namespace VanillaAdditions.Content.Proj.ChestArrows
{
	public class DesertBiomePoint : ModProjectile
    {
        public override string Texture => "VanillaAdditions/Assets/Proj/ChestArrows/DesertBiomePointer";

        public bool foundDesertChest;
        public Color textureColor = new(r: 0f, g: 0f, b: 0f, alpha: 0f);
        public Vector2 desertChestPosition;
        public override void SetDefaults()
        {
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;

            Projectile.width = 24;
            Projectile.height = 22;
        }
        public override void AI()
        {
            float glowingRange = 2000f; //distance from chest in order for projectile to glow
            float intesity;
            
            Player player = Main.player[Projectile.owner];

            //kill proj if conditions not met
            if (!player.dead && player.HasItem(ItemID.DungeonDesertKey))
            {
                Projectile.timeLeft = 2;
            }
            else
            {
                Projectile.timeLeft = 0;
                player.GetModPlayer<PlayerVariables>().keyFound = false;
            }

            //move proj and point at chest
            Projectile.Center = new Vector2(player.Center.X, player.Center.Y - 50);
            for (int i = 0; i < Main.chest.Length && !foundDesertChest; i++)
            {
                Chest chest = Main.chest[i];
                if (chest.item[0].type == ItemID.StormTigerStaff)
                {
                    desertChestPosition = new Vector2(chest.x * 16, chest.y * 16);
                    foundDesertChest = true;
                }
            }
            Vector2 direction = Projectile.DirectionTo(desertChestPosition);
            float distance = Projectile.Center.Distance(desertChestPosition);
            Projectile.rotation = direction.ToRotation();

            //lighting and glowmask
            if (distance <= glowingRange)
            {
                intesity = (distance - glowingRange) * -0.001f / 2;
            }
            else
            {
                intesity = 0f;
            }
            textureColor = new(r: intesity, g: intesity, b: intesity, alpha: intesity);
            Lighting.AddLight(Projectile.Center, intesity, intesity / 2f, 0.1f);
        }
        public override void PostDraw(Color lightColor)
        {
            Texture2D texture2D = ModContent.Request<Texture2D>("VanillaAdditions/Assets/Proj/ChestArrows/gl_DesertBiomePointer", AssetRequestMode.ImmediateLoad).Value;

            Main.spriteBatch.Draw
                (
                texture: texture2D,
                position: new Vector2(
                        Projectile.position.X - Main.screenPosition.X + Projectile.width * 0.5f,
                        Projectile.position.Y - Main.screenPosition.Y + Projectile.height - texture2D.Height * 0.5f),
                new Rectangle(0, 0, texture2D.Width, texture2D.Height),
                color: textureColor,
                rotation: Projectile.rotation,
                origin: texture2D.Size() * 0.5f,
                scale: Projectile.scale,
                SpriteEffects.None,
                layerDepth: 0f
                );
            Lighting.AddLight(Projectile.Center, 0.6f, 0.3f, 0.1f);
        }
    }
}