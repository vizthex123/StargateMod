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
			DisplayName.SetDefault("Naquadah");
            Tooltip.SetDefault("A rare, super-dense mineral used for all Ancient and Goa'uld technology.\nWill generate naturally soon™");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            //item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperOre, 3);
			recipe.AddIngredient(ItemID.IronOre, 3);
			recipe.AddIngredient(ItemID.SilverOre, 3);
			recipe.AddIngredient(ItemID.GoldOre, 3);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinOre, 3);
			recipe.AddIngredient(ItemID.LeadOre, 3);
			recipe.AddIngredient(ItemID.TungstenOre, 3);
			recipe.AddIngredient(ItemID.PlatinumOre, 3);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
			
			
			// Swap between ore varients
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.TinOre);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.CopperOre);
			recipe.AddRecipe();
		
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.LeadOre);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.IronOre);
			recipe.AddRecipe();
			
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.TungstenOre);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.SilverOre);
			recipe.AddRecipe();
			
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.PlatinumOre);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.GoldOre);
			recipe.AddRecipe();
        }
    }
}