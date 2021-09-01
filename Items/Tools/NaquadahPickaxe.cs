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
            Tooltip.SetDefault("A pickaxe made from an unstable metal\nThis definitely won't backfire!");
        }
		// Make it explode every so often because Naquadah
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.autoReuse = true;
			Item.DamageType = DamageClass.Melee;
			Item.damage = 10;
			Item.knockBack = 3;
			Item.pick = 105;
			Item.useTime = 17;
			Item.useStyle = 1;
			Item.tileBoost = 1;
			Item.UseSound = SoundID.Item1;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 5);
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<NaquadahBar>(6)
				.AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}
// Thanks to Oli.H#3090 on the TML Discord for the tile reach code!