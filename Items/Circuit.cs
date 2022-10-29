using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items
{
    public class Circuit : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Circuit");
            Tooltip.SetDefault("Some circuitry that can be used for a variety of things.\nA commonality between every species.");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 250;
            Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(silver: 30);
        }
/*
        public override void AddRecipeGroups() {
			// Create a recipe group and store it
			// Language.GetTextValue("LegacyMisc.37") is the word "Any" in english, and the corresponding word in other languages
			ExampleRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ModContent.ItemType<Items.ExampleItem>())}",
				ModContent.ItemType<Items.ExampleItem>(), ModContent.ItemType<Items.ExampleDataItem>());

			// To avoid name collisions, when a modded items is the iconic or 1st item in a recipe group, name the recipe group: ModName:ItemName
			RecipeGroup.RegisterGroup("StargateMod:CopperBar", CopperBarRecipeGroup);
		}
*/
        public override void AddRecipes()
        {
			CreateRecipe(3)
				.AddIngredient(ItemID.CopperBar, 3)
				.AddIngredient(ItemID.GoldBar, 1)
				.AddRecipeGroup(RecipeGroupID.Sand, 3)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(3)
				.AddIngredient(ItemID.TinBar, 5)
				.AddIngredient(ItemID.PlatinumBar, 2)
				.AddRecipeGroup(RecipeGroupID.Sand, 5)
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