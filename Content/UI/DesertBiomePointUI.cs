/*using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Humanizer;
using Terraria.UI;
using Microsoft.Xna.Framework.Graphics;

namespace VanillaAdditions.Content.Proj.ChestArrows
{
    public class DesChestPointerElement : UIElement
    {
        public override void Draw(SpriteBatch spriteBatch)
        {
            Color color = new Color(50, 255, 153);

            spriteBatch.Draw((Texture2D)ModContent.Request<Texture2D>("VanillaAdditions/Assets/Proj/ChestArrows/DesertBiomePointer"), new Vector2(Main.screenWidth + 20, Main.screenHeight - 20) / 2f, ); //Main.screenWidth / 2, Main.screenHeight / 2
        }
    }

    public class DesChestPointerState : UIState
    {
        public DesChestPointerElement DesChestArrow;

        public override void OnInitialize()
        {
            DesChestArrow = new DesChestPointerElement();

            Append(DesChestArrow);
        }
    }
}*/