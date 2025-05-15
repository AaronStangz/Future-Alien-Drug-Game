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
    public int GiveCronaSeed;
    public int GiveTwertaSeed;
    public int GivePlaronSeed;
    [Space]
    public int GiveCronalean;
    public int GiveTwertapop;
    public int GivePlaronloss;
    [Space]
    public int GiveBottledCronalean;
    public int GiveBottledTwertapop;
    public int GiveBottledPlaronloss;
    [Space]
    public int GiveBottle;
    [Space]
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
        if (MM.Space <= MM.MaxSpace) { MM.CronaSeed += GiveCronaSeed; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.TwertaSeed += GiveTwertaSeed; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.PlaronSeed += GivePlaronSeed; Destroy(gameObject); }

        if (MM.Space <= MM.MaxSpace) { MM.Cronalean += GiveCronalean;  Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.Twertapop += GiveTwertapop; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.Plaronloss += GivePlaronloss; Destroy(gameObject); }

        if (MM.Space <= MM.MaxSpace) { MM.BottledCronalean += GiveBottledCronalean; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.BottledTwertapop += GiveBottledTwertapop; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.BottledPlaronloss += GiveBottledPlaronloss; Destroy(gameObject); }

        if (MM.Space <= MM.MaxSpace) { MM.Bottle += GiveBottle; Destroy(gameObject); }

        if (MM.Space <= MM.MaxSpace) { MM.Squashor += GiveSquashor; Destroy(gameObject); }
        if (MM.Space <= MM.MaxSpace) { MM.Radiator += GiveRadiator; Destroy(gameObject); }
    }
}