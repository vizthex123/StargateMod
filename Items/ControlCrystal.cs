using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items//.LanteanParts
{
    public class ControlCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Control Crystal");
            Tooltip.SetDefault("A crystal that controls most functions in Ancient technology.");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 100;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 50);
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<Crystal>(2)
				.AddIngredient<Circuit>(1)
				.AddIngredient(ItemID.GoldBar, 3)
				.AddIngredient(ItemID.CopperBar, 1)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<Crystal>(2)
				.AddIngredient<Circuit>(1)
				.AddIngredient(ItemID.PlatinumBar, 3)
				.AddIngredient(ItemID.TinBar, 1)
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