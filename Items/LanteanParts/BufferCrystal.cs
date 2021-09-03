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
            Tooltip.SetDefault("A crystal that provides a buffer between Control Crystals and circuitry\nWithout this, things would probably overload");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 100;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 40);
        }

        public override void AddRecipes()
        {
			CreateRecipe(2)
				.AddIngredient<Crystal>(3)
				.AddIngredient<Circuit>(1)
				.AddIngredient(ItemID.GoldBar, 2)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(2)
				.AddIngredient<Crystal>(3)
				.AddIngredient<Circuit>(1)
				.AddIngredient(ItemID.PlatinumBar, 2)
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