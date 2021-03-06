
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Modding.Items.Weapons.Ammo
{
	public class GasCanister : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded bullet ammo.");
		}

		public override void SetDefaults() {
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 40.0f;
			item.value = 10;
			item.rare = 4;
			item.shoot = ProjectileType<Projectiles.Laser>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 30f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		// // Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
		// public override void OnConsumeAmmo(Player player)
		// {
		// 	if (Main.rand.NextBool(2)) {
		// 		player.AddBuff(BuffID.Honey, 500);
		// 	}
		// }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 500);
			recipe.AddRecipe();
		}

	}
}
