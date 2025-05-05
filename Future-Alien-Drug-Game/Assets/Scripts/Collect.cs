using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    private bool hasRun = false;
    [Space]
    public int pickUpRange;
    [Space]
    public int GiveSnuzzlefern;
    public int GiveThwackroot;
    public int GiveGlarpCactus;
    [Space]
    public int GiveSnuzzlefernSeed;
    public int GiveThwackrootSeed;
    public int GiveGlarpCactusSeed;
    [Space]
    public int GiveBottle;
    [Space]
    public int GiveSeedStorage;
    public int GiveFruitStorage;
    public int GiveWeaponLocker;
    [Space]
    public int GivePlanter;
    public int GiveSquashor;
    public int GiveRadiator;

    void Start()
    {
        mainManager = GameObject.Find("Main Manager");
        MM = mainManager.GetComponent<MainManager>();
    }

    public void CollectItem()
    {
        MyFunctionToRunOnce();
        hasRun = true;
    }

    void MyFunctionToRunOnce()
    {
        if (MM.Space <= MM.MaxSpace) { MM.Space += 1; }
        if (MM.Space <= MM.MaxSpace) { MM.Snuzzlefern += GiveSnuzzlefern; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.Thwackroot += GiveThwackroot; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.GlarpCactus += GiveGlarpCactus; Destroy(gameObject); }

        if (MM.Space <= MM.MaxSpace) { MM.SnuzzlefernSeed += GiveSnuzzlefernSeed;  Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.ThwackrootSeed += GiveThwackrootSeed; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.GlarpCactusSeed += GiveGlarpCactusSeed; Destroy(gameObject); }

        if (MM.Space <= MM.MaxSpace) { MM.Bottle += GiveBottle; Destroy(gameObject); }

        if (MM.Space <= MM.MaxSpace) { MM.SeedStorage += GiveSeedStorage; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.FruitStorage += GiveFruitStorage; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.WeaponLocker += GiveWeaponLocker; Destroy(gameObject); }

        if (MM.Space <= MM.MaxSpace) { MM.Planter += GivePlanter; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.Squashor += GiveSquashor; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.Radiator += GiveRadiator; Destroy(gameObject); }
    }
}