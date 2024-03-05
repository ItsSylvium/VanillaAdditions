using System;
using System.Linq;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.Personalities;
using Terraria.DataStructures;
using System.Collections.Generic;
using ReLogic.Content;
/*

namespace VanillaAddtions.Content.NPCs.TownNPCs
{
    // [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
    [AutoloadHead]
    public class TheWayfarer : ModNPC
    {
        public override string Texture => "VanillaAdditions/Assets/NPCs/TownNPCs/TheWayfarer";
        //public override string[] AltTextures => new[] { "ExampleMod/NPCs/ExamplePerson_Alt_1" };

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("WayFarer");
            Main.npcFrameCount[NPC.type] = 25;
            NPCID.Sets.ExtraFramesCount[NPC.type] = 9;
            NPCID.Sets.AttackFrameCount[NPC.type] = 4;
            NPCID.Sets.DangerDetectRange[NPC.type] = 700;
            NPCID.Sets.AttackType[NPC.type] = 0;
            NPCID.Sets.AttackTime[NPC.type] = 90;
            NPCID.Sets.AttackAverageChance[NPC.type] = 30;
            NPCID.Sets.HatOffsetY[NPC.type] = -10;


            //NPCID.Sets.NPCBestiaryDrawOffset.Add(Type,);

            NPC.Happiness
                .SetBiomeAffection<UndergroundBiome>(AffectionLevel.Love)
                .SetBiomeAffection<ForestBiome>(AffectionLevel.Like)
                .SetBiomeAffection<SnowBiome>(AffectionLevel.Dislike)
                .SetBiomeAffection<DesertBiome>(AffectionLevel.Hate)

                //.SetNPCAffection(NPCID.Dryad, AffectionLevel.) HES A MOLE
                .SetNPCAffection(NPCID.Dryad, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Cyborg, AffectionLevel.Dislike)
                .SetNPCAffection(NPCID.Mechanic, AffectionLevel.Dislike)
                .SetNPCAffection(NPCID.Demolitionist, AffectionLevel.Hate)
            ;
        }

        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 32;
            NPC.height = 30;
            NPC.aiStyle = 7;
            NPC.damage = 10;
            NPC.defense = 15;
            NPC.lifeMax = 250;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            AnimationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k]; //check if player is in the world?
                if (!player.active)
                {
                    continue;
                }

                if (NPC.downedMechBoss1 == true) //check if destroyer is killed
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override List<string> SetNPCNameList()
        {
            return new List<string>()
            {
                "Arlo", //All possible npc names
                "Corin",
                "Edaiplat",
                "Eris",
                "Gunnar",
                "Hanz",
                "Leon",
                "Moale",
                "Peronn",
                "Pidae",
                "Taply"
            };
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}
        }

        public override string GetChat()
        {
            WeightedRandom<string> chat = new WeightedRandom<string>();

            int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
            if (partyGirl >= 0 && Main.rand.NextBool(4))
            {
                chat.Add("Can you please tell " + Main.npc[partyGirl].GivenName + " to stop decorating my house with colors?");
            }
            chat.Add("Sometimes I feel like I'm different from everyone else here.");
            chat.Add("What's your favorite color? My favorite colors are white and black.");
            chat.Add("What? I don't have any arms or legs? Oh, don't be ridiculous!");
            chat.Add("This message has a weight of 5, meaning it appears 5 times more often.", 5.0);
            chat.Add("This message has a weight of 0.1, meaning it appears 10 times as rare.", 0.1);
            return chat; // chat is implicitly cast to a string.
        }
        public override void SetChatButtons(ref string button, ref string button2)
        { // What the chat buttons are when you open up the chat UI
            button = Language.GetTextValue("LegacyInterface.28");
        }
        public override void OnChatButtonClicked(bool firstButton, ref string WayfarerShop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            //Stones
            shop.item[nextSlot].SetDefaults(ItemID.StoneBlock);
            shop.item[nextSlot].shopCustomPrice = 3;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.SiltBlock);
            shop.item[nextSlot].shopCustomPrice = 20;
            nextSlot++;
            //Ores
            shop.item[nextSlot].SetDefaults(ItemID.CopperOre);
            shop.item[nextSlot].shopCustomPrice = 100;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.TinOre);
            shop.item[nextSlot].shopCustomPrice = 140;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.IronOre);
            shop.item[nextSlot].shopCustomPrice = 200;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.LeadOre);
            shop.item[nextSlot].shopCustomPrice = 300;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.SilverOre);
            shop.item[nextSlot].shopCustomPrice = 300;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.TungstenOre);
            shop.item[nextSlot].shopCustomPrice = 450;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.GoldOre);
            shop.item[nextSlot].shopCustomPrice = 600;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.PlatinumOre);
            shop.item[nextSlot].shopCustomPrice = 900;
            nextSlot++;
            //Gems
            shop.item[nextSlot].SetDefaults(ItemID.Amethyst);
            shop.item[nextSlot].shopCustomPrice = 750;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Topaz);
            shop.item[nextSlot].shopCustomPrice = 1500;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Sapphire);
            shop.item[nextSlot].shopCustomPrice = 2250;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Emerald);
            shop.item[nextSlot].shopCustomPrice = 3000;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Ruby);
            shop.item[nextSlot].shopCustomPrice = 4500;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Amber);
            shop.item[nextSlot].shopCustomPrice = 6000;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Diamond);
            shop.item[nextSlot].shopCustomPrice = 6000;
            nextSlot++;
            
            if (Main.LocalPlayer.HasBuff(BuffID.Lifeforce))
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ExampleHealingPotion>());
                nextSlot++;
            }
            if (Main.LocalPlayer.GetModPlayer<ExamplePlayer>().ZoneExample && !ModContent.GetInstance<ExampleConfigServer>().DisableExampleWings)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ExampleWings>());
                nextSlot++;
            }
            if (Main.moonPhase < 2)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ExampleSword>());
                nextSlot++;
            }
            else if (Main.moonPhase < 4)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ExampleGun>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Weapons.ExampleBullet>());
                nextSlot++;
            }
            else if (Main.moonPhase < 6)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ExampleStaff>());
                nextSlot++;
            }
            else
            {
            }
        }

        
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Armor.ExampleCostume>());          PUT GORE HERE
        }
        


                                    // Due to the Wayfarer lack of gender they may not be teleported to a king or queen statue


        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 60;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.ThrowingKnife;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}
*/