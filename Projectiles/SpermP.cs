using Terraria.ID;
using Terraria.ModLoader;

namespace Modding.Projectiles
{

    public class SpermP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sperm");
		}
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = 30;
            projectile.timeLeft = 200;
            projectile.light = 1f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
    }
}
