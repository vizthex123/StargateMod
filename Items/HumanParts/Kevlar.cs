using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.HumanParts
{
    public class Kevlar : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Kevlar");
            Tooltip.SetDefault("Composite silk and iron with a high durability.\nUsed to craft human armor");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 10);
        }

        public override void AddRecipes()
        {
			CreateRecipe(2)
				.AddIngredient(ItemID.Silk, 5)
				.AddRecipeGroup(RecipeGroupID.IronBar, 1)
				.AddTile(TileID.Loom)
				.Register();
        }
    }
}