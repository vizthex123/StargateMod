using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Stargate.Buffs
{
    public class DeathGliderBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Death Glider");
            Description.SetDefault("A Goa'uld Death Glider will slay your enemies");
            Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
        }
		
		public override void Update(Player player, ref int buffIndex) {
			// Should let this buff stay basically forever
			if (player.ownedProjectileCounts[ModContent.ProjectileType<Minions.DeathGlider>()] > 0) {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
    }
}