using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : Building
{
    GameObject target;

    private void Start()
    {
        InvokeRepeating("Fire", 0.0f, 1.0f);
    }

    void Fire()
    {
        GetClosestTarget();
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
