using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Accessories
{
    public class ZPMBooster : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Zero-Point Speed Booster");
            Tooltip.SetDefault("Harnesses Zero-Point Energy to dilate time so the user moves faster\nWhen equipped, it will boost movement speed by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            //item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 5;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.moveSpeed += 0.10f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("ZPMCasing"), 1);
			recipe.AddIngredient(mod.GetItem("ZPM"), 1);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(mod.TileType("AncientCrafter"));
			// Basically a table used to craft Ancient items, same ones apply to each faction. Can combine them all into one (Hybrid Tables, each with different combos [Human/Asgard, Human/Goa'uld, etc.]) later.
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