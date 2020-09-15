using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Stargate.Items.Tools
{
    public class NaquadahPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Naquadah Pickaxe");
            Tooltip.SetDefault("A pickaxe made from an unstable metal\nThis definitely won't go wrong.");
        }
		// Make it explode every so often because Naquadah
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            //item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
			item.pick = 60;
			item.knockBack = 4;
			item.melee = true;
			item.autoReuse = true;
			item.useStyle = 1;
			item.UseSound = SoundID.Item1;
			item.tileBoost = 1;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Naquadah"), 12);
			recipe.AddRecipeGroup("Wood", 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Thanks to Oli.H#3090 on the TML Discord for the tile reach code!