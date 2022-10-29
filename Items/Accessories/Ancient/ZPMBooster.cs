using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Accessories.Ancient
{
    public class ZPMBooster : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Zero-Point Speed Booster");
            Tooltip.SetDefault("Harnesses Zero-Point Energy to dilate time, allowing the user to move faster\n+25% Movement Speed");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 1);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.moveSpeed += 0.25f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<Items.Ancient.ZPM>(1)
				.AddIngredient<AncientParts.ZPMCasing>(1)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}