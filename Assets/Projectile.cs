using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public enum ProjectileType
    {
        Damage
    }

    public ProjectileType type;
    public int value;
    public float speed;

    private void FixedUpdate()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}
