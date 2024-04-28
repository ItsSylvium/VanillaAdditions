using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using System;
using System.Net.Mime;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;         //Make it so if the pet is really far away it squirts a bunch of blood porpelling itself towards the player

namespace VanillaAdditions.Common.GlobalEnemy.GlobalBoss.DreadNautilus
{
    public class DreadConchPet : ModProjectile
    {
        public override string Texture => "VanillaAdditions/Assets/Boss/DreadNautilus/DreadConchPet";
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 7; //divides the sheet by this number to get frame size
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.LightPet[Projectile.type] = true;
        }
        public override void SetDefaults()
        {
            Projectile.width = 32; //hitbox size
            Projectile.height = 30;

            Projectile.friendly = true;
            Projectile.penetrate = -1; //i think this just means it will infinitly penetrate
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            Vector2 idlePosition = new(player.Center.X + (-20 * player.direction), player.position.Y + -40);
            Vector2 distance = idlePosition - Projectile.Center;
            distance.Normalize();
            float between = Projectile.Center.Distance(idlePosition);
            float inertia = 40f;

            if (!player.dead && player.HasBuff(ModContent.BuffType<DreadConchBuff>()))
            {
                Projectile.timeLeft = 2;
            }

            Lighting.AddLight(Projectile.Center, 0.8f, 0.2f, 0.2f);

            if (between < 40f)
            {
                inertia = 20f;
                IdleAnimation();
                Projectile.spriteDirection = -player.direction;
            }
            if (between >= 40f && between < 600f)
            {
                distance *= 8;
                IdleAnimation();
                Projectile.spriteDirection = -Projectile.direction;
            }
            else if (between >= 600f)
            {
                distance *= 10;
                InkAnimation();
                Projectile.spriteDirection = Projectile.direction;
            }

            Projectile.velocity = (Projectile.velocity * (inertia - 1f) + distance) / inertia;
        }
        private void IdleAnimation()
        {
            Projectile.frameCounter++;
            if (Projectile.frameCounter >= 8)
            {
                Projectile.frameCounter = 0;
                Projectile.frame++;
                if (Projectile.frame >= 4)
                {
                    Projectile.frame = 0;
                }
            }
        }
        private void InkAnimation()
        {
            Dust.NewDustDirect(Projectile.Center, 0, 0, DustID.Asphalt, Projectile.velocity.X * -1f, Projectile.velocity.Y * -1f);

            Projectile.frameCounter++;
            if (Projectile.frameCounter >= 5)
            {
                if (Projectile.frame >= 6 && Projectile.frameCounter != 0)
                {
                    Projectile.frameCounter = 0;
                    Projectile.frame = 5;
                }
                if (Projectile.frame <= 5 && Projectile.frameCounter != 0)
                {
                    Projectile.frameCounter = 0;
                    Projectile.frame = 6;
                }
            }
        }
    }
}
