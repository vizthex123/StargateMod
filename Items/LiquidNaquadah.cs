using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Items
{
    public class LiquidNaquadah : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Liquid Naquadah");
            Tooltip.SetDefault("Weapons-grade naquadah, melted down and placed into a capsule\nHas a variety of uses, chief of which is to provide ammunition for Ma'Tok Staves");
        }

        public override void SetDefaults()
        {
			Item.damage = 10;
			Item.knockBack = 5; 
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
			Item.ammo = Item.type;
			Item.consumable = true;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = ModContent.ProjectileType<Projectiles.NaquadahLaser>();
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 2);
        }

        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<NaquadahBar>(2)
			// .AddTile(mod.TileType("NaquadahRefiner"))
				.AddTile(TileID.Hellforge)
				.Register();
        }
    }
}