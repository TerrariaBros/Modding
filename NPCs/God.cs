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
           Main.npcFrameCount[npc.type] = 16; //this defines how many frames the npc sprite sheet has
           NPCID.Sets.ExtraFramesCount[npc.type] = 9;
           NPCID.Sets.AttackFrameCount[npc.type] = 4;
           NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
           NPCID.Sets.AttackType[npc.type] = 3; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee)
           NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
           NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
           NPCID.Sets.HatOffsetY[npc.type] = 4; //this defines the party hat position
           animationType = NPCID.Guide;
         }
   }
}
