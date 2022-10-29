using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Accessories.Human
{
    public class BulletproofVest : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Bulletproof Vest");
            Tooltip.SetDefault("Reinforced Kevlar that blocks some damage.\n+5 Defense");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense += 5;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<HumanParts.Kevlar>(10)
				.AddRecipeGroup(RecipeGroupID.IronBar, 3)
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

//Will become a piece of armour later™ but that needs a lot of sprites which I can't do.