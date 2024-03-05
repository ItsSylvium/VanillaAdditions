/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanillaAdditions.Content.GlobalItems
{
    public class MyGlobalTile : GlobalTile
    {
		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
		{
			if (Tile.type == 61)
            {
				Texture2D texture = ModContent.Request<Texture2D>("VanillaAdditions/Content/GlobalItems/Natures_Gift_Glowmask", AssetRequestMode.ImmediateLoad).Value;
				spriteBatch.Draw
				(
					texture,
					new Vector2
					(
						item.position.X - Main.screenPosition.X + item.width * 0.5f,
						item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
					),
					new Rectangle(0, 0, texture.Width, texture.Height),
					Color.White,
					rotation,
					texture.Size() * 0.5f,
					scale,
					SpriteEffects.None,
					0f
				);
			}
		}
	}
}*/