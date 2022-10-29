using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Accessories.Goauld
{
    public class HealingDevice : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Goa'uld Healing Device");
            Tooltip.SetDefault("A handheld device made by the Goa'uld that helps heal wounds.\nHeals woulds five times as fast as a Band of Regeneration.");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 1);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.lifeRegen += 5;
			// Band of Regen is 1
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<Naquadah>(10)
				.AddIngredient<NaquadahCasing>(1)
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