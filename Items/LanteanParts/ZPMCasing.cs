using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.LanteanParts
{
    public class ZPMCasing : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Zero-Point Module Casing");
            Tooltip.SetDefault("Holds Zero-Point modules and extracts their energy.");
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
			recipe.AddIngredient(ItemID.SilverBar, 15);
			recipe.AddIngredient(mod.GetItem("Crystal"), 10);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(mod.TileType("AncientCrafter"));
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 15);
			recipe.AddIngredient(mod.GetItem("Crystal"), 10);
			recipe.AddTile(TileID.WorkBenches);
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