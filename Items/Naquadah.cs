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
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1);
        }

        public override void AddRecipes()
        {
			CreateRecipe(3)
				.AddIngredient(ItemID.CopperOre, 3)
				.AddIngredient(ItemID.IronOre, 3)
				.AddIngredient(ItemID.SilverOre, 3)
				.AddIngredient(ItemID.GoldOre, 3)
				.AddTile(TileID.Furnaces)
				.Register();
			
			CreateRecipe(3)
				.AddIngredient(ItemID.TinOre, 3)
				.AddIngredient(ItemID.LeadOre, 3)
				.AddIngredient(ItemID.TungstenOre, 3)
				.AddIngredient(ItemID.PlatinumOre, 3)
				.AddTile(TileID.Furnaces)
				.Register();
			
			/*
			// Swap between ore varients
			CreateRecipe(ItemID.TinOre, 1)
				.AddIngredient(ItemID.CopperOre)
				.AddTile(TileID.Bottles)
				.Register();
			
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
			*/
        }
    }
}