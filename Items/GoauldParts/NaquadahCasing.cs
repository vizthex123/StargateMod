using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.GoauldParts
{
    public class NaquadahCasing : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Naquadah Casing");
            Tooltip.SetDefault("Casing used to hold Goa'uld devices and batteries.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            //item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 10);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}