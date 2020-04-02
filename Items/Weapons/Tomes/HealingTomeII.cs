using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Modding.Items.Weapons.Tomes
{
	public class HealingTomeII : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Healing II");
			Tooltip.SetDefault("Blessed with The Power of the Universe");
		}
		public override void SetDefaults()
		{
		item.damage = 0;
		item.magic = true; //this make the item do magic damage
		item.width = 24;
		item.height = 28;
		item.useTime = 10;
		item.useAnimation = 10;
		item.useStyle = 5; //this is how the item is held
		item.noMelee = true;
		item.knockBack = 0;
		item.value = 1000000;
		item.rare = 6;
		item.mana = 20; //mana use
		item.UseSound = SoundID.Item21; //this is the sound when you use the item
		item.autoReuse = true;
		item.healLife = 20;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.LifeFruit, 5);
			recipe.AddIngredient(mod.ItemType("HealingTomeI"));
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
