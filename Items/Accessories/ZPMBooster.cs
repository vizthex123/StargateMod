using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Accessories
{
    public class ZPMBooster : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Zero-Point Speed Booster");
            Tooltip.SetDefault("Harnesses Zero-Point Energy to dilate time so the user moves faster\n+10% Movement Speed");
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
			player.moveSpeed += 0.10f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<LanteanParts.ZPMCasing>(1)
				.AddIngredient<ZPM>(1)
			 //.AddTile(mod.TileType("AncientCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}