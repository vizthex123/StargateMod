using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Weapons
{
    public class DeathGlider : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Death Glider Battery");
            Tooltip.SetDefault("Summons a small Death Glider to aid the player");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            //item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
			item.summon = true;
			item.damage = 16;
			item.knockBack = 5;
			item.buffType = BuffType<DeathGlider>();
			item.shoot = ProjectileType<GliderLaser>();
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Naquadah"), 10);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Still heavily WIP because idk how to program weapons and projectiles and whatnot.