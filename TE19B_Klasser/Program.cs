using System;

namespace TE19B_Klasser
{
  class Program
  {
    static void Main(string[] args)
    {
      Enemy goomba = new Enemy();

      goomba.name = "Goomba";
      goomba.health = 100;
      goomba.health -= 8;
      goomba.health += 3;

      Console.WriteLine($"Name: {goomba.name} Health: {goomba.health}");

      Console.ReadLine();
      
    }
  }
}
