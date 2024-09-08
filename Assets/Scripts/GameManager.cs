using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int wave = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            NextWave();
        }
    }

    public static void NextWave()
    {
        wave++;
        EnemyManager.InitiateWave();
    }
}
