using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    public static void SpawnHero(GameObject building, Vector3 position)
    {
        Instantiate(building, position, Quaternion.identity, GameObject.Find("Buildings").transform);
    }
}
