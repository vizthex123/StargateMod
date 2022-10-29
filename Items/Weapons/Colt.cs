using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items.Weapons
{
    public class Colt : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Colt M1911A1");
            Tooltip.SetDefault("One of many standard Tau'ri sidearms");
        }

        public override void SetDefaults()
        {
			Item.damage = 23;
			Item.knockBack = 4;
			Item.shootSpeed = 7;
			Item.useTime = 17;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.DamageType = DamageClass.Ranged;
			Item.UseSound = SoundID.Item11;
			Item.useAmmo = AmmoID.Bullet;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1);
            Item.maxStack = 1;
			Item.noMelee = true;
			Item.shoot = ProjectileID.PurificationPowder;
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<Items.HumanParts.PistolParts>(1)
				.AddRecipeGroup(RecipeGroupID.IronBar, 7)
			  //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}