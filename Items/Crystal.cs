using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items//.LanteanParts
{
    public class Crystal : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Basic Crystal");
            Tooltip.SetDefault("A basic structural crystal used in all Ancient (Lantean) technology.");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 100;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 25);
        }

        public override void AddRecipes()
        {
			CreateRecipe(12)
				.AddIngredient(ItemID.CopperBar, 10)
				.AddRecipeGroup(RecipeGroupID.IronBar, 15)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(12)
				.AddIngredient(ItemID.TinBar, 10)
				.AddRecipeGroup(RecipeGroupID.IronBar, 15)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
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