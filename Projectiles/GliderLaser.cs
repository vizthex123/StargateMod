using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Stargate.Projectiles
{
	public class GliderLaser : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Death Glider Laser");
		}

		public override void SetDefaults()
		{
			projectile.alpha = 100;
			projectile.width = 15;
			projectile.height = 10;
			projectile.aiStyle = 1; //Should be a laser
			aiType = ProjectileID.GreenLaser;
			projectile.friendly = true;
			projectile.summon = true;
			projectile.damage = 16;
			projectile.maxPenetrate = 1;
		}
	}
}
*/
// Todo: Make this actually fire from high-tier {7+} Soul Swords, finish the code