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
            Tooltip.SetDefault("A weapon of terror, wielded by all Jaffa.\nSomewhat effective, but not very accurate.\nRequires 1 Liquid Naquadah per shot");
        }

        public override void SetDefaults()
        {
			Item.damage = 20;
			Item.knockBack = 2;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = ModContent.ProjectileType<Projectiles.NaquadahLaser>();
			Item.useAmmo = ModContent.ItemType<LiquidNaquadah>();
			Item.UseSound = SoundID.Item12;
		    Item.shoot = 10;
		    Item.shootSpeed = 8;
			Item.width = 20;
			Item.height = 20;
			Item.scale = 1f;
			Item.useTime = 25;
			Item.useAnimation = 10;
			Item.useStyle = 5;
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(copper: 0);
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<NaquadahBar>(5)
				.AddRecipeGroup(RecipeGroupID.IronBar, 8)
			 //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}