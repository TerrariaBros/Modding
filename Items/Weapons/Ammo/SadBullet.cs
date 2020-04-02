
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Modding.Items.Weapons.Ammo
{
	public class SadBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Do you really want to hurt Mr. Fluffers?");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 10.0f;
			item.value = 100;
			item.rare = 6;
			item.shoot = ProjectileType<Projectiles.SadEagle>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = .3f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		// Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
		public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(2))
			{
				player.AddBuff(BuffID.Honey, 60*5);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 200);
			recipe.AddRecipe();
		}

	}
}
