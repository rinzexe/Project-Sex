using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Object
{
    public int health;
    public float speed;

    override public void ProjectileCollision(Collider2D collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.GetComponent<Projectile>() != null)
        {
            Projectile proj = collision.gameObject.GetComponent<Projectile>();
            health -= proj.value;

            if (health < 0)
            {
                Destroy(gameObject);
            }

            Destroy(collision.gameObject);
        }
    }
}
