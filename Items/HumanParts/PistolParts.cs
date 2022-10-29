using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.HumanParts
{
    public class PistolParts : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Pistol Parts");
            Tooltip.SetDefault("A basic shell used to house the various mechanical pieces of a Tau'ri pistol");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(silver: 5);
        }

        public override void AddRecipes()
        {
			CreateRecipe(2)
				.AddRecipeGroup(RecipeGroupID.IronBar, 3)
				.AddRecipeGroup(RecipeGroupID.Wood, 5)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}