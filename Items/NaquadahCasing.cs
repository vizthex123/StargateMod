using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items//.GoauldParts
{
    public class NaquadahCasing : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Naquadah Casing");
            Tooltip.SetDefault("A specaizlied casing used to contain & stabilize Naquadah");
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
				.AddIngredient(ItemID.CopperBar, 10)
				.AddIngredient(ItemID.GoldBar, 10)
			 //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient(ItemID.TinBar, 10)
				.AddIngredient(ItemID.PlatinumBar, 10)
			 //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}