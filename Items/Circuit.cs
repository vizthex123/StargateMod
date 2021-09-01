using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items//.UniversalParts
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
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 30);
        }

        public override void AddRecipes()
        {
			CreateRecipe(3)
				.AddIngredient(ItemID.CopperBar, 3)
				.AddIngredient(ItemID.GoldBar, 1)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(3)
				.AddIngredient(ItemID.TinBar, 3)
				.AddIngredient(ItemID.PlatinumBar, 1)
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