using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Ammo
{
    public class LiquidNaquadah : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Liquid Naquadah");
            Tooltip.SetDefault("Naquadah that has been melted down\nCan be used to power Goa'uld Staff Weapons, as well as Naquadah Generators.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            //item.value = Item.sellPrice(0, 1, 10, 0);
            item.rare = 2;
			item.ammo = item.type;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Naquadah"), 6);
			recipe.AddIngredient(ItemID.LavaBucket, 2);
			recipe.AddTile(TileID.Hellforge);
			// Crafting station that will refine Naquadahinto its various other forms
			//recipe.AddTile(mod.TileType("NaquadahRefiner"));
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
        }
    }
}