using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items
{
    public class NaquadahBar : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Weapons-Grade Naquadah");
            Tooltip.SetDefault("A rare, super-dense mineral used for all Ancient and Goa'uld technology.\nRefined enough to be used in weaponry.\nDoesn't pack well");
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
			CreateRecipe(3)
				.AddIngredient<Naquadah>(25)
			// .AddTile(mod.TileType("NaquadahRefiner"))
				.AddTile(TileID.Hellforge)
				.Register();
        }
    }
}