using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items//.GoauldParts
{
    public class NaquadahCore : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Naquadah Core");
            Tooltip.SetDefault("A powerful energy core, fueled with Naquadah");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 50;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<NaquadahCasing>(1)
				.AddIngredient<LiquidNaquadah>(10)
				.AddIngredient<NaquadahBar>(1)
			 //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}