using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static bool isPlacing = false;
    static GameObject heroToPlace;

    public static void StartHeroPlacement(GameObject hero)
    {
        isPlacing = true;
        heroToPlace = hero;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && isPlacing == true)
        {
            isPlacing = false;

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            HeroManager.SpawnHero(heroToPlace, new Vector3(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y)));
        }
    }
}
