using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Projectiles
{
	public class NaquadahLaser : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Naquadah Laser");
		}

		public override void SetDefaults()
		{
			AIType = ProjectileID.GreenLaser;
			Projectile.damage = 10;
			Projectile.alpha = 100;
			Projectile.width = 15;
			Projectile.height = 10;
			Projectile.friendly = true;
			Projectile.penetrate = 1;
		}
	}
}