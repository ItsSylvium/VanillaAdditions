using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanillaAdditions.Common.GlobalEnemy.GlobalBoss.Mothron

{
    public class MothronBabyProj : ModProjectile
    {
        public override string Texture => "VanillaAdditions/Assets/Boss/Mothron/MothronBabyProj";
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 4; //divides the sheet by this number to get frame size
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.LightPet[Projectile.type] = true;
        }
        public override void SetDefaults()
        {
            Projectile.width = 42; //hitbox size
            Projectile.height = 40;
            Projectile.aiStyle = 26;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            AIType = ProjectileID.ZephyrFish;
        }
        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.zephyrfish = false; // Relic from aiType
            return true;
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<MothronBabyBuff>()))
            {
                Projectile.timeLeft = 2;
            }

            Projectile.frameCounter -= 2; //this part is courtise of naylddd, i could not for the life of me figure it out
            if (Projectile.frameCounter <= -6)
            {
                Projectile.frameCounter = 0;
                Projectile.frame = (Projectile.frame + 1) % Main.projFrames[Projectile.type];
            }

            Main.projFrames[Type] = 4;
        }
    }
}
