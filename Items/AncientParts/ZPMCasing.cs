using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.AncientParts
{
    public class ZPMCasing : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Zero-Point Casing");
            Tooltip.SetDefault("Secures Zero-Point modules so they can be used without problems arising");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 10;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 1);
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.SilverBar, 5)
				.AddIngredient<Crystal>(1)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient(ItemID.TungstenBar, 5)
				.AddIngredient<Crystal>(1)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}

// Used for Hardmode stuff
// Can be found - Still WIP
/* Crystals:
Yellow - Buffer
Red - Control
Green - Auxiliary
Orange - Regular (Crystal)
*/