using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : Object
{
    public float detectionRange;
    public float coldResistance;
    public float health;

    public List<GameObject> targets;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            targets.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            targets.Remove(collision.gameObject);
        }
    }
}
