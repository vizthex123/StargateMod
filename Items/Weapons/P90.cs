using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Weapons
{
    public class P90 : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("P90");
            Tooltip.SetDefault("A weapon of war, wielded by all Stargate teams.\nVery effective, but not very accurate.");
        }

        public override void SetDefaults()
        {
			Item.damage = 10;
			Item.knockBack = 2;
			Item.shootSpeed = 10;
			Item.useTime = 9;
			Item.autoReuse = true;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.DamageType = DamageClass.Ranged;
			Item.UseSound = SoundID.Item11;
			Item.useAmmo = AmmoID.Bullet;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 10);
            Item.maxStack = 1;
			Item.noMelee = true;
			Item.shoot = ProjectileID.PurificationPowder;
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<NaquadahBar>(3)
				.AddRecipeGroup(RecipeGroupID.IronBar, 5)
				.AddIngredient(ItemID.Minishark, 1)
			  //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
			/*
			var shark = ItemID.Megashark();
			
			// Can be used to craft a Megashark
			shark.CreateRecipe()
				.AddIngredient<P90>(1)				
				.AddIngredient(ItemID.IllegalGunParts, 1)
				.AddIngredient(ItemID.SharkFin, 5)
				.AddIngredient(ItemID.SoulofMight, 15)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			*/
        }
    }
}