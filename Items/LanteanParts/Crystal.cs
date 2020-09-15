using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.LanteanParts
{
    public class Crystal : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Basic Crystal");
            Tooltip.SetDefault("A basic structural crystal used in Ancient technology.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 100;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 2;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 10);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 12);
			recipe.AddRecipe();
			
			new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 10);
			recipe.AddIngredient(ItemID.LeadBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 12);
			recipe.AddRecipe();
        }
    }
}

// Used for Ancient tech (ZPM's, Antarctic Drone, etc.)
/* Crystals:
Yellow - Buffer
Red - Control
Green - Auxiliary
Orange - Regular (Crystal)
*/