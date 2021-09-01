using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items//.LanteanParts
{
    public class ZPM : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Zero-Point Module");
            Tooltip.SetDefault("A generator capable of producing massive amounts of energy.\nUsed to power most Ancient (Lantean) technologies.\nGets its power from zero-point energy pockets in other dimensions.\nStacks to 10");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 10;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 5);
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<Circuit>(3)
				.AddIngredient<Crystal>(5)
				.AddIngredient<ControlCrystal>(4)
				.AddIngredient<BackupCrystal>(3)
				.AddIngredient<BufferCrystal>(2)
				.AddIngredient<ZPMCasing>(1)
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