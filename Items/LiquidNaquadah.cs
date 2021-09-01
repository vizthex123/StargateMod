using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items//.Ammo
{
    public class LiquidNaquadah : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Liquid Naquadah");
            Tooltip.SetDefault("Naquadah that has been melted down\nCan be used to power Ma'Tok Staves and Naquadah Generators");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
			//Item.ammo = Item.type;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 2);
        }

        public override void AddRecipes()
        {
			CreateRecipe(3)
				.AddIngredient<Naquadah>(6)
				.AddIngredient(ItemID.LavaBucket, 1)
			// .AddTile(mod.TileType("NaquadahRefiner"))
				.AddTile(TileID.Hellforge)
				.Register();
        }
    }
}