/*
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Projectiles
{
	public class DeathGlider : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Death Glider");
			Main.projPet[Projectile.type] = true;
			Main.projFrames[Projectile.type] = 1;
			//ProjectileID.Sets.MinionTargettingFeature[Projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[Projectile.type] = true;
			ProjectileID.Sets.Homing[Projectile.type] = true;
		}

		public override void SetDefaults()
		{
			//AIType = ProjectileID.GreenLaser;
			Projectile.friendly = true;
			Projectile.minion = true;
			Projectile.minionSlots = 1f; // Make it take 2 slots later, but have stronks
			Projectile.penetrate = -1;
			Projectile.damage = 20;
			Projectile.alpha = 100;
			Projectile.width = 15;
			Projectile.height = 10;
		}
	}
}
*/