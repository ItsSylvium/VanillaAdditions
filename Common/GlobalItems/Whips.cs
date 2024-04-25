using Terraria;
using Terraria.ModLoader;
using System.Linq;

namespace VanillaAdditions.Common.GlobalItems
{
    public class Whips : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            int[] array = new int[] { 4672, 4678, 4679, 4680, 4911, 4912, 4913, 4914, 5074, };
            if (array.Contains(item.type))
            {
                item.autoReuse = true;
            }
        }
    }
}
