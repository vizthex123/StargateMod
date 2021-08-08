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
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            //item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
			/*
			item.ranged = true;
			item.useAmmo = mod.ItemType("LiquidNaqudah");
			item.damage = 16;
			item.knockBack = 2;
		    item.shoot = 10;
		    item.shootSpeed = 8;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.scale = 1f;
			*/
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("NaquadahBar"), 5);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("NaquadahBar"), 5);
			recipe.AddIngredient(ItemID.LeadBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Still heavily WIP because idk how to program weapons and projectiles and whatnot.