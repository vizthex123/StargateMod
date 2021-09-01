using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Accessories
{
    public class GoauldHealthBooster : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Goa'uld Health Booster");
            Tooltip.SetDefault("A device made by the Goa'uld that increases your longevity when implanted into one's heart\n+50 Max HP while equipped\nHeals wounds slightly slower than a Healing Device");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 1);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2 += 50;
			player.lifeRegen += 3;
			// Band of Regen is 1
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<Naquadah>(25)
				.AddIngredient<LiquidNaquadah>(15)
				.AddIngredient<GoauldHealingDevice>(1)
			//	.AddTile(mod.TileType("GoauldCrafter"))
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