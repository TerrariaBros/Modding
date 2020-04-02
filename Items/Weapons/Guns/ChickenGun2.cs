using Terraria.ID;
using Terraria.ModLoader;

namespace Modding.Items.Weapons.Guns
{
	public class ChickenGun2: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Cockernator");
			Tooltip.SetDefault("Eggcelent Destruction");
			Tooltip.SetDefault("YEETS");
		}
		public override void SetDefaults()
		{
			item.damage = 60;
			item.ranged = true;
			item.width = 62;
			item.height = 38;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(mod.ItemType("ChickenGun"), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
