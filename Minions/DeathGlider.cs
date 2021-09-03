using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Minions
{
	public class DeathGlider : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Death Glider");
			ProjectileID.Sets.MinionTargettingFeature[Projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[Projectile.type] = true;
			//ProjectileID.Sets.Homing[Projectile.type] = true;
			Main.projPet[Projectile.type] = true;
			Main.projFrames[Projectile.type] = 1;
		}

		public override void SetDefaults()
		{
			AIType = ProjectileID.GreenLaser;
			Projectile.damage = 16;
			Projectile.alpha = 100;
			Projectile.width = 15;
			Projectile.height = 10;
			Projectile.penetrate = -1;
			Projectile.friendly = true;
			Projectile.minion = true;
			Projectile.minionSlots = 1f;
		}
	}
}