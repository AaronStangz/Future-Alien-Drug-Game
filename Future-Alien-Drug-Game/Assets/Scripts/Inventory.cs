using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;
    [Space]
    public GameObject mainCamera;
    PlayerCam MC;

    public GameObject GUI;
    public GameObject Pad;
    public GameObject Player;

    public int openRange;
    public bool UIOpen;

    public Transform Content;

    public GameObject PreSnuzzlefernSeed;
    public GameObject PreThwackrootSeed;
    public GameObject PreGlarpCactusSeed;

    public GameObject PreSnuzzlefern;
    public GameObject PreThwackroot;
    public GameObject PreGlarpCactus;

    public GameObject PreBottle;

    public GameObject PreSeedStorage;
    public GameObject PreFruitStorage;
    public GameObject PreWeaponLocker;

    public GameObject PrePlanter;
    public GameObject PreSquashor;
    public GameObject PreRadiator;

    public GameObject PreBat;
    public GameObject PrePan;
    public GameObject PreGloves;

    public GameObject PrePistol;
    public GameObject PreRevolver;
    public GameObject PreTeaser;

    private int SnuzzlefernSeedPre;
    private int ThwackrootSeedPre;
    private int GlarpCactusSeedPre;

    private int SnuzzlefernPre;
    private int ThwackrootPre;
    private int GlarpCactusPre;

    private int BottlePre;

    private int SeedStoragePre;
    private int FruitStoragePre;
    private int WeaponLockerPre;

    private int PlanterPre;
    private int SquashorPre;
    private int RadiatorPre;

    private int BatPre;
    private int PanPre;
    private int GlovesPre;

    private int PistolPre;
    private int RevolverPre;
    private int TeaserPre;

    private int MaxSpacePre;
    private int SpacePre;

    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
        MC = mainCamera.GetComponent<PlayerCam>();
        GUI.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Escape) && UIOpen)
        {
            UIOpen = false;
            GUI.SetActive(false);
            Pad.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            MC.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Open();
        }

            if (MM.SnuzzlefernSeed > SnuzzlefernSeedPre)
            {
                Instantiate(PreSnuzzlefernSeed, Content);
            }
            SnuzzlefernSeedPre = MM.SnuzzlefernSeed;

            if (MM.ThwackrootSeed > ThwackrootSeedPre)
            {
                Instantiate(PreThwackrootSeed, Content);
            }
            ThwackrootSeedPre = MM.ThwackrootSeed;

            if (MM.GlarpCactusSeed > GlarpCactusSeedPre)
            {
                Instantiate(PreGlarpCactusSeed, Content);
            }
            GlarpCactusSeedPre = MM.GlarpCactusSeed;




            if (MM.Snuzzlefern > SnuzzlefernPre)
            {
                Instantiate(PreSnuzzlefern, Content);
            }
            SnuzzlefernPre = MM.Snuzzlefern;

            if (MM.Thwackroot > ThwackrootPre)
            {
                Instantiate(PreThwackroot, Content);
            }
            ThwackrootPre = MM.Thwackroot;

            if (MM.GlarpCactus > GlarpCactusPre)
            {
                Instantiate(PreGlarpCactus, Content);
            }
            GlarpCactusPre = MM.GlarpCactus;




        if (MM.Bottle > BottlePre)
        {
            Instantiate(PreBottle, Content);
        }
        BottlePre = MM.Bottle;



        if (MM.SeedStorage > SeedStoragePre)
        {
            Instantiate(PreSeedStorage, Content);
        }
        SeedStoragePre = MM.SeedStorage;

        if (MM.FruitStorage > FruitStoragePre)
        {
            Instantiate(PreFruitStorage, Content);
        }
        FruitStoragePre = MM.FruitStorage;

        if (MM.WeaponLocker > WeaponLockerPre)
        {
            Instantiate(PreWeaponLocker, Content);
        }
        WeaponLockerPre = MM.WeaponLocker;




    }

    public void Open()
    {
        MC = mainCamera.GetComponent<PlayerCam>();
        MM = mainManager.GetComponent<MainManager>();

        UIOpen = true;
        Pad.SetActive(true);
        GUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        MC.enabled = false;
    }
}
