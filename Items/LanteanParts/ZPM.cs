using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.LanteanParts
{
    public class ZPM : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Zero-Point Module");
            Tooltip.SetDefault("A generator capable of producing massive amounts of energy.\nUsed to power and craft most Ancient technologies.\nGets its power from zero-point energy pockets in other dimensions.\nStacks to 10");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 10;
            //item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 5;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Circuit"), 4);
			recipe.AddIngredient(mod.GetItem("Crystal"), 5);
			recipe.AddIngredient(mod.GetItem("ControlCrystal"), 4);
			recipe.AddIngredient(mod.GetItem("BackupCrystal"), 3);
			recipe.AddIngredient(mod.GetItem("BufferCrystal"), 2);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(mod.TileType("AncientCrafter"));
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}

// Used for Hardmode stuff
// Can be found - Still WIP
/* Crystals:
Yellow - Buffer
Red - Control
Green - Auxiliary
Orange - Regular (Crystal)
*/