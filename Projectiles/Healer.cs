namespace Modding.Projectiles
{
public class Healer : ModProjectile
{
    //If you want to store information, place fields here.

    public override void OnSpawn()
    {
        projectile.netImportant = true;
    }

    public override void AI()
    {
        Player player = Main.player[projectile.owner];
        Player modPlayer = player.GetSubClass<Player>();
        if(!player.active)
        {
            projectile.active = false;
            return;
        }
        if(player.dead)
        {
            modPlayer.exampleMinion = false;
        }
        if(modPlayer.exampleMinion)
        {
            projectile.timeLeft = 2;
        }
        //In the source code, some variables were set up here to keep track of things; you might want to do the same.
        if(projectile.ai[1] == 0f)
        {
            if(player.rocketDelay2 > 0)
            {
                projectile.ai[0] = 1f;
            }
            //Fill in with your own code. If the player is too far away, set projectile.ai[0] = 1f. If the player is even more too far away, teleport the projectile to the player instead.
        }
        if(projectile.ai[0] != 0f)
        {
            projectile.tileCollide = false;
            //Adjust projectile.velocity to make the projectile fly towards the player here.
            //Set projectile.spriteDirection to 1 or -1 to make it look like it's facing a certain direction.
            UpdateFrame();
            //If you want, you can make dust (the colorful particles) here; in fact you can make dust wherever you want.
        }
        else
        {
            projectile.tileCollide = true;
            //Make your minion do what it would normally do here, attacking enemies or following you.
            //Make sure to set projectile.friendly to true if it is attacking, and set it to false if it is not attacking; this is very important!
            //If projectile.friendly is set to false, your minion will not do damage.
            //If projectile.friendly is set to true, your minion will destroy all the plants and stuff, which is annoying.
            //Set projectile.spriteDirection to 1 or -1 to make it look like it's facing a certain direction.
            UpdateFrame();
            projectile.velocity.Y += 0.4f; //This updates gravity.
            if(projectile.velocity.Y > 10f)
            {
                projectile.velocity.Y = 10f; //So it doesn't fall way too fast. Yes, positive is downwards.
            }
        }
        Damage();
    }

    private void Damage()
    {
        Player player = Main.player[projectile.owner];
        //Copy over the code from Projectile.Damage() from Terraria's source code, then remove the first two if statements and replace all of the "this" with "projectile".
    }

    private void UpdateFrame()
    {
        //Set projectile.frame here based on your projectile's state. I'll explain what this is later. To keep track of animation time, you can use projectile.frameCounter.
        projectile.frameCounter++; //Only if you are using projectile.frameCounter.
        projectile.frameCounter %= 10; //Or however long you want one cycle of animation to last.
    }
  }
}
