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
			Item.damage = 16;
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
			Item.DamageType = DamageClass.Summon;
            Item.buffType = BuffType<Buffs.DeathGliderBuff>();
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 1);
        }
		/*
		public override bool Shoot(Player player, ProjectileSource_Item_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			// This is needed so the buff that keeps your minion alive and allows you to despawn it properly applies
			player.AddBuff(Item.buffType, 2);

			//Minions have to be spawned manually, then have originalDamage assigned to the damage of the summon item
			var projectile = Projectile.NewProjectileDirect(source, position, velocity, type, damage, knockback, Main.myPlayer);
			projectile.originalDamage = Item.damage;

			//Since we spawned the projectile manually already, we do not need the game to spawn it for ourselves anymore, so return false
			return false;
		}
		*/
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<NaquadahBar>(10)
				.AddRecipeGroup(RecipeGroupID.IronBar, 4)
			 //.AddTile(mod.TileType("GoauldCrafter"))
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}