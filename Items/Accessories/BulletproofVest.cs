using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Accessories
{
    public class BulletproofVest : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Bulletproof Vest");
            Tooltip.SetDefault("Reinforced Kevlar that blocks some damage.\nWhen equipped, it gives +5 Defense");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            //item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 3;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense += 5;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Kevlar"), 10);
			recipe.AddTile(TileID.Loom);
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

//Will become a piece of armour later™ but that needs a lot of sprites which I can't do.