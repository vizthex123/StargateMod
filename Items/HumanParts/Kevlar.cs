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
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            //item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 4);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
			
			new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 4);
			recipe.AddIngredient(ItemID.LeadBar, 4);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
        }
    }
}