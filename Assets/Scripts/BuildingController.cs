using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : Building
{
    GameObject target;
    public GameObject bullet;

    private void Start()
    {
        InvokeRepeating("Fire", 0.0f, 1.0f);
    }

    void Fire()
    {
        GetClosestTarget();

        if (target != null)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(transform.position.y - target.transform.position.y, transform.position.x - target.transform.position.x) * Mathf.Rad2Deg + 90);
            Instantiate(bullet, transform.position, rotation);
        }
    }

    void GetClosestTarget()
    {
        if (targets.Count > 0)
        {
            GameObject closest = targets[0];
            foreach (var itarget in targets)
            {
                if (Vector3.Distance(itarget.transform.position, transform.position) < Vector3.Distance(transform.position, closest.transform.position))
                {
                    closest = itarget;
                }
            }
            target = closest;
        }
    }
}
