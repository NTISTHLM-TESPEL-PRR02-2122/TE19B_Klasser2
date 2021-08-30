using System;

namespace TE19B_Klasser
{
  public class Enemy
  {
    public float x;
    public float y;

    public string name;

    public int health;
    public int damage;

    private float speed = 2.5f;

    public HealthPickup weapon = new HealthPickup();

    

    public void Move()
    {
      x += speed;
    }

    public void Hurt(int amount)
    {
      health -= amount;

      if (health < 0)
      {
        health = 0;
      }

      // Dödskod
    }

    // Skada spelaren
    // Röra sig (+speed)
    // Hoppa
    // Bli skadad
    // Dö
    // Skapas
  }
}