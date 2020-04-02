using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Modding.Items.Weapons.Staffs
{
  public class HealerStaff : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("HealerStaff");
      Tooltip.SetDefault("Summons The Healer as a follower to fight alongside you");
    }
    public override void SetDefaults()
    {
      item.summon = true;
      item.mana = 20;
      item.damage = 200;
      item.height = 26;
      item.width = 26;
      item.usetime = 30;
      item.useAnimation = 30;
      item.usestyle =1;
      item.nomelee = true;
      item.knockback = 5;
      item.value = 5000000;
      item.rare = 4;
      item.UseSound = SoundId.Item44;
      item.shoot = mod.Projectiletype("SpermP");
      item.shootSpeed = 10f;
    }
    public override bool AltFunctionUse(Player player)
    {
      return true;
    }
    public override bool shoot(player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
    {
      return player.AltFunctionUse != 2;
    }
    public override bool UseItem(player player)
    {
      if(player.AltFunctionUse ==2)
      {
        player.MinionNPCTargetAim();
      }
      return basw.UseItem(player);
    }
  }
}
