using Terraria;
using Terraria.ModLoader;
using System.Linq;

namespace VanillaAdditions.Content.GlobalItems
{
    public class Whips : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == 4952) //Nightglow
            {
                item.damage = 90;
            }
            if (item.type == 4953) //Eventide
            {
                item.damage = 100;
            }
        }
    }
}
