using System;

namespace TE19B_Klasser
{
  class Program
  {
    static void Main(string[] args)
    {
      Enemy goomba = new Enemy();

      goomba.weapon.healthGain = 6;

      HealthPickup healthPack = new HealthPickup();

      healthPack.x = 900;

      goomba.name = "Goomba";
      goomba.health = 100;
      goomba.health -= 2;
      goomba.health += 3;

      goomba.Hurt(2);

      Console.WriteLine($"Name: {goomba.name} Health: {goomba.health}");

      Console.ReadLine();
      
    }
  }
}
