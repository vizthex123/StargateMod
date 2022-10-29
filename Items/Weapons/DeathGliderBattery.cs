/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace Stargate.Items.Weapons
{
    public class DeathGliderBattery : ModItem
    {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Death Glider Battery");
			Tooltip.SetDefault("Summons a small Death Glider to aid the player");
			ItemID.Sets.GamepadWholeScreenUseRange[Item.type] = true; // This lets the player target anywhere on the whole screen while using a controller.
			ItemID.Sets.LockOnIgnoresCollision[Item.type] = true;
		}

        public override void SetDefaults()
        {
			Item.damage = 20;
			Item.knockBack = 5;
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.UseSound = SoundID.Item44; // Should be the default "staff" sound. Make it more sci-fi later on.
			Item.useStyle = ItemUseStyleID.Swing;
			Item.noMelee = true;
			Item.autoReuse = false;
			Item.consumable = false;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 1);
			Item.DamageType = DamageClass.Summon;
			Item.buffType = BuffType<DeathGliderBuff>();
			Item.shoot = ProjectileType<DeathGlider>();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			player.AddBuff(item.buffType, 2, true);
			position = Main.MouseWorld;
			return true;
		}

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<NaquadahBar>(10)
				.AddRecipeGroup(RecipeGroupID.IronBar, 15)
			 //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}
*/