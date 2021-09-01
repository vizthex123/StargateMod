using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items//.LanteanParts
{
    public class BackupCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Auxiliary Control Crystal");
            Tooltip.SetDefault("A crystal used as a precaution against malfunctions");
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
			CreateRecipe(3)
				.AddIngredient<Crystal>(4)
				.AddIngredient(ItemID.CopperBar, 4)
				.AddIngredient(ItemID.SilverBar, 3)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(3)
				.AddIngredient<Crystal>(4)
				.AddIngredient(ItemID.TinBar, 4)
				.AddIngredient(ItemID.TungstenBar, 3)
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