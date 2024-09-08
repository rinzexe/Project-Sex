using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] spawnAreas;
    public GameObject enemy;

    static EnemyManager instance;
    static GameObject self;

    private void Awake()
    {
        instance = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
        self = GameObject.Find("EnemyManager");
    }

    public static void InitiateWave()
    {
        foreach (var area in instance.spawnAreas)
        {
            Bounds bounds = area.GetComponent<BoxCollider2D>().bounds;

            Vector3 spawnArea = bounds.center + new Vector3(
                (float)(Random.value - 0.5) * bounds.size.x,
                (float)(Random.value - 0.5) * bounds.size.y,
                0
            );
            Instantiate(instance.enemy, spawnArea, Quaternion.identity, GameObject.Find("Enemies").transform);
        }
    }
}
