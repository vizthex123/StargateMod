using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items
{
    public class Naquadah : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Weapons-Grade Naquadah");
            Tooltip.SetDefault("A rare, super-dense mineral used for all Ancient and Goa'uld technology.\nRefined enough to be used in weaponry.\nDoesn't pack well.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 10;
            //item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Naquadah"), 25);
			recipe.AddTile(TileID.Hellforge);
			// Crafting station that will refine Naquadah into its various other forms
			//recipe.AddTile(mod.TileType("NaquadahRefiner"));
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
        }
    }
}