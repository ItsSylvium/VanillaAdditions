using Microsoft.Xna.Framework;
using System;
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
            Vector2 idleOffset = new(-40 * player.direction, -40);
            Vector2 direction = (player.Center + idleOffset) - Projectile.Center;
            float speed = 8f;
            direction.Normalize();
            direction *= speed;
            float between = Vector2.Distance((player.Center + idleOffset), Projectile.Center);
            float wave = Projectile.ai[0] * 0.025f;
            float inertia = 40f;
            bool close;
            Projectile.ai[0]++;

            // Projectile no die like this
            if (!player.dead && player.HasBuff(ModContent.BuffType<DreadConchBuff>()))
            {
                Projectile.timeLeft = 2;
            }
            Projectile.ai[0]++;

            if (between <= 50f)
            {
                Projectile.velocity = (Projectile.velocity * (inertia - 1) + direction) / inertia;
                Projectile.velocity.Y = (float)Math.Sin(wave) * 2;
                //Projectile.velocity = new Vector2(Projectile.velocity.X * (inertia - 1) / inertia, (float)Math.Sin(wave) * 2);
            }
            if (between > 50f && between <= 400f)
            {
                Projectile.velocity = (Projectile.velocity * (inertia - 1) + direction) / inertia;
            }
            else
            {
                inertia *= 2;
                Projectile.velocity = (Projectile.velocity * (inertia - 1) + direction) / inertia;
            }


            //Projectile.Center = player.Center + idleOffset;
            //Projectile.velocity = new Vector2(0, (float)Math.Sin(wave) * 16);
            
            /*Projectile.frameCounter -= 2; //this part is courtise of naylddd, i could not for the life of me figure it out
            if (Projectile.frameCounter <= -6)
            {
                Projectile.frameCounter = 0;
                Projectile.frame = (Projectile.frame + 1) % Main.projFrames[Projectile.type];
            }

            Main.projFrames[Type] = 7;

            if (!Main.dedServ)
            {
                Lighting.AddLight(Projectile.Center, Projectile.Opacity * 0.9f, Projectile.Opacity * 0.1f, Projectile.Opacity * 0.3f); //make it much less intense
            }
            //Projectile.owner*/
        }
    }
}
