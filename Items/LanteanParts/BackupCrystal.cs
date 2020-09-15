using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.LanteanParts
{
    public class BackupCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Auxiliary Crystal");
            Tooltip.SetDefault("A crystal used as a precaution against malfunctions");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 100;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 3;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Crystal"), 4);
			recipe.AddIngredient(ItemID.CopperBar, 4);
			recipe.AddIngredient(ItemID.SilverBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
			
			new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Crystal"), 4);
			recipe.AddIngredient(ItemID.TinBar, 4);
			recipe.AddIngredient(ItemID.TungstenBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 4);
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