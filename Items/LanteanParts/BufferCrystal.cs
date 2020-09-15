using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.LanteanParts
{
    public class BufferCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Buffer Crystal");
            Tooltip.SetDefault("A crystal that provides a buffer between Control Crystals and circuitry");
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
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
			
			new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Crystal"), 4);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
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