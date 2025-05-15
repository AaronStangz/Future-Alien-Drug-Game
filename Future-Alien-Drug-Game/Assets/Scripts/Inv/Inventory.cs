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

    public GameObject PreCronaSeed;
    public GameObject PreTwertaSeed;
    public GameObject PrePlaronSeed;

    public GameObject PreCronalean;
    public GameObject PreTwertapop;
    public GameObject PrePlaronloss;

    public GameObject PreBottledCronalean;
    public GameObject PreBottledTwertapop;
    public GameObject PreBottledPlaronloss;

    public GameObject PreBottle;


    public GameObject PrePlanter;
    public GameObject PreSquashor;
    public GameObject PreRadiator;

    public GameObject PreBat;
    public GameObject PrePan;
    public GameObject PreGloves;

    public GameObject PrePistol;
    public GameObject PreRevolver;
    public GameObject PreTeaser;

    public int CronaSeedPre;
    public int TwertaSeedPre;
    public int PlaronSeedPre;

    public int CronaleanPre;
    public int TwertapopPre;
    public int PlaronlossPre;

    public int BottledCronaleanPre;
    public int BottledTwertapopPre;
    public int BottledPlaronlossPre;

    public int BottlePre;

    public int SeedStoragePre;
    public int FruitStoragePre;
    public int WeaponLockerPre;

    public int PlanterPre;
    public int SquashorPre;
    public int RadiatorPre;

    public int BatPre;
    public int PanPre;
    public int GlovesPre;

    public int PistolPre;
    public int RevolverPre;
    public int TeaserPre;

    public int MaxSpacePre;
    public int SpacePre;

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

        if (MM.CronaSeed > CronaSeedPre)
        {
            Instantiate(PreCronaSeed, Content);
        }
        CronaSeedPre = MM.CronaSeed;
        if (MM.CronaSeed < CronaSeedPre) { RemoveItem("CronaSeed"); }

        if (MM.TwertaSeed > TwertaSeedPre)
        {
            Instantiate(PreTwertaSeed, Content);
        }
        TwertaSeedPre = MM.TwertaSeed;
        if (MM.TwertaSeed < TwertaSeedPre) { RemoveItem("TwertaSeed"); }

        if (MM.PlaronSeed > PlaronSeedPre)
        {
            Instantiate(PrePlaronSeed, Content);
        }
        PlaronSeedPre = MM.PlaronSeed;
        if (MM.PlaronSeed < PlaronSeedPre) { RemoveItem("PlaronSeed"); }




        if (MM.Cronalean > CronaleanPre)
        {
            Instantiate(PreCronalean, Content);
        }
        if (MM.Cronalean < CronaleanPre) { RemoveItem("Cronalean"); }
        CronaleanPre = MM.Cronalean;

        if (MM.Twertapop > TwertapopPre)
        {
            Instantiate(PreTwertapop, Content);
        }
        TwertapopPre = MM.Twertapop;
        if (MM.Twertapop < TwertapopPre) { RemoveItem("Twertapop"); }

        if (MM.Plaronloss > PlaronlossPre)
        {
            Instantiate(PrePlaronloss, Content);
        }
        PlaronlossPre = MM.Plaronloss;
        if (MM.Plaronloss < PlaronlossPre) { RemoveItem("Plaronloss"); }



        if (MM.BottledCronalean > BottledCronaleanPre)
        {
            Instantiate(PreBottledCronalean, Content);
        }
        BottledCronaleanPre = MM.BottledCronalean;
        if (MM.BottledCronalean < BottledCronaleanPre) { RemoveItem("BottledCronalean"); }

        if (MM.BottledTwertapop > BottledTwertapopPre)
        {
            Instantiate(PreBottledTwertapop, Content);
        }
        BottledTwertapopPre = MM.BottledTwertapop;
        if (MM.BottledTwertapop < BottledTwertapopPre) { RemoveItem("BottledTwertapop"); }


        if (MM.BottledPlaronloss > BottledPlaronlossPre)
        {
            Instantiate(PreBottledPlaronloss, Content);
        }
        BottledPlaronlossPre = MM.BottledPlaronloss;
        if (MM.BottledPlaronloss < BottledPlaronlossPre) { RemoveItem("BottledPlaronloss"); }


        if (MM.Bottle > BottlePre)
        {
            Instantiate(PreBottle, Content);
        }
        if (MM.Bottle < BottlePre) { RemoveItem("Bottle"); }
        BottlePre = MM.Bottle;

    }
    public void RemoveItem(string tagname)
    {
        for (int i = 0; i < Content.childCount; i++)
        {
            Transform child = Content.GetChild(i);
            if (child.tag == tagname)
            {
                Destroy(child.gameObject);
                print("Removed");
                return;
            }
        }
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
