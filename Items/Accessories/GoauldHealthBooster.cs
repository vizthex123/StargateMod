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
            Tooltip.SetDefault("A device made by the Goa'uld that increases your longevity when implanted into one's heart\n+50 Max HP while equipped\nSlightly increases life regen");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            //item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 5;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2 += 50;
			player.lifeRegen += 3;
			// Band of Regen is 1
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Naquadah"), 25);
			recipe.AddIngredient(mod.GetItem("LiquidNaquadah"), 15);
			recipe.AddIngredient(mod.GetItem("GoauldHealingDevice"), 1);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(mod.TileType("GoauldCrucible"));
			// A vat of magical science that makes Goa'uld technology
			recipe.SetResult(this);
			recipe.AddRecipe();
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