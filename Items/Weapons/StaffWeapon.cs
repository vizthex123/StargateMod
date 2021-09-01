/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Weapons
{
    public class StaffWeapon : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Ma'Tok Staff");
            Tooltip.SetDefault("[HEAVILY WIP!]\nA weapon of terror, used by all Jaffa.\nVery effective, but not very accurate.\nRequires 1 Liquid Naquadah per shot");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            //Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 3;
			Item.ranged = true;
			Item.useAmmo = mod.ItemType("LiquidNaqudah");
			Item.damage = 16;
			Item.knockBack = 2;
		    Item.shoot = 10;
		    Item.shootSpeed = 8;
			Item.useAnimation = 10;
			Item.useStyle = 5;
			Item.scale = 1f;
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<NaquadahBar>(5)
				.AddRecipeGroup(RecipeGroupID.IronBar, 8)
			 //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.Anvils)
				.Register()
        }
    }
}
// Still heavily WIP because idk how to program weapons and projectiles and whatnot.
*/