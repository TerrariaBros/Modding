using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Modding.NPCs
{
  public class God : ModNPC
  {
    public override string Texture => "Modding/NPCs/God";
    public override bool Autoload(ref string name)
        {
            name = "God";
            return mod.Properties.Autoload;
        }
    public override void SetDefaults()
       {
           npc.townNPC = true; //This defines if the npc is a town Npc or not
           npc.friendly = true;  //this defines if the npc can hur you or not()
           npc.width = 18; //the npc sprite width
           npc.height = 46;  //the npc sprite height
           npc.aiStyle = 7; //this is the npc ai style, 7 is Pasive Ai
           npc.defense = 25;  //the npc defense
           npc.lifeMax = 250;// the npc life
           npc.HitSound = SoundID.NPCHit1;  //the npc sound when is hit
           npc.DeathSound = SoundID.NPCDeath1;  //the npc sound when he dies
           npc.knockBackResist = 0.5f;  //the npc knockback resistance
           Main.npcFrameCount[npc.type] = 26; //this defines how many frames the npc sprite sheet has
           NPCID.Sets.ExtraFramesCount[npc.type] = 9;
           NPCID.Sets.AttackFrameCount[npc.type] = 4;
           NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
           NPCID.Sets.AttackType[npc.type] = 3; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee)
           NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
           NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
           NPCID.Sets.HatOffsetY[npc.type] = 4; //this defines the party hat position
           animationType = NPCID.Guide;
         }
         public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window.
      {
          button = "Buy Potions";   //this defines the buy button name
      }
      public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
      {

          if (firstButton)
          {
              openShop = true;   //so when you click on buy button opens the shop
          }
      }

      public override void SetupShop(Chest shop, ref int nextSlot)       //Allows you to add items to this town NPC's shop. Add an item by setting the defaults of shop.item[nextSlot] then incrementing nextSlot.
      {
          if (NPC.downedSlimeKing)   //this make so when the king slime is killed the town npc will sell this
          {
              shop.item[nextSlot].SetDefaults(ItemID.RecallPotion);  //an example of how to add a vanilla terraria item
              nextSlot++;
              shop.item[nextSlot].SetDefaults(ItemID.WormholePotion);
              nextSlot++;
          }
          if (NPC.downedBoss3)   //this make so when Skeletron is killed the town npc will sell this
          {
              shop.item[nextSlot].SetDefaults(ItemID.BookofSkulls);
              nextSlot++;
              shop.item[nextSlot].SetDefaults(ItemID.ClothierVoodooDoll);
              nextSlot++;
          }
          shop.item[nextSlot].SetDefaults(ItemID.IronskinPotion);
          nextSlot++;
          shop.item[nextSlot].SetDefaults(mod.ItemType("ChickenGun"));  //this is an example of how to add a modded item
          nextSlot++;
          shop.item[nextSlot].SetDefaults(mod.ItemType("ChickenGun2"));  //this is an example of how to add a modded item
          nextSlot++;
          shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleBullet"));  //this is an example of how to add a modded item
          nextSlot++;

      }

      public override string GetChat()       //Allows you to give this town NPC a chat message when a player talks to it.
      {
          switch (Main.rand.Next(4))    //this are the messages when you talk to the npc
          {
              case 0:
                  return "You wanna buy something?";
              case 1:
                  return "What you want?";
              case 2:
                  return "I like this house.";
              case 3:
                  return "<I'm blue dabu di dabu dai>....OH HELLO THERE..";
              default:
                  return "Go kill Skeletron.";

          }
      }
   }
}
