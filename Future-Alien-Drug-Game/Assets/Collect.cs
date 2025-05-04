using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    public GameObject hotBar;
    HotBar HB;
    [Space]
    public int pickUpRange;
    [Space]
    [Space]
    public int GiveSeed1;
    public int GiveSeed2;
    public int GiveSeed3;
    [Space]
    public int GiveFruit1;
    public int GiveFruit2;
    public int GiveFruit3;

    void Start()
    {
        mainManager = GameObject.Find("Main Manager");
        MM = mainManager.GetComponent<MainManager>();
        hotBar = GameObject.Find("Player");
        HB = hotBar.GetComponent<HotBar>();
    }

    public void CollectItem()
    {
        if (MM.Seed1 >= 1 || HB.SeedSlotOpen == true) { MM.Seed1 += GiveSeed1; Destroy(gameObject); }
        if (MM.Seed2 >= 1 || HB.SeedSlotOpen == true) { MM.Seed2 += GiveSeed2; Destroy(gameObject); }
        if (MM.Seed3 >= 1 || HB.SeedSlotOpen == true) { MM.Seed3 += GiveSeed3; Destroy(gameObject); }

        MM.Fruit1 += GiveFruit1;
        MM.Fruit2 += GiveFruit2;
        MM.Fruit3 += GiveFruit3;
        Destroy(gameObject);
    }
}