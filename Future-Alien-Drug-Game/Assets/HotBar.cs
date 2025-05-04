using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HotBar : MonoBehaviour
{
    MainManager MM;
    public GameObject mainManager;

    public GameObject MalaySlot;
    public GameObject GunSlot;
    public GameObject SeedSlot;
    public GameObject FruitSlot;
    public GameObject StorageSlot;
    public GameObject EquipmentSlot;

    public bool MalaySlotOpen;
    public bool GunSlotOpen;
    public bool SeedSlotOpen;
    public bool FruitSlotOpen;
    public bool StorageSlotOpen;
    public bool EquipmentSlotOpen;

    public GameObject[] SeedImage;
    public GameObject[] SeedHand;

    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MM != null)
        {
            if (MM.Seed1 == 0 && MM.Seed2 == 0 && MM.Seed3 == 0) { SeedSlot.SetActive(false); SeedSlotOpen = true; 
                foreach (GameObject Image in SeedImage) { Image.SetActive(false);} 
                foreach (GameObject hand in SeedHand) { hand.SetActive(false);} }
            if (MM.Seed1 == 1) {SeedSlot.SetActive(true); ToggleSeedImage(0); SeedSlotOpen = false; }
            if (MM.Seed2 == 1) {SeedSlot.SetActive(true); ToggleSeedImage(1); SeedSlotOpen = false; }
            if (MM.Seed3 == 1) {SeedSlot.SetActive(true); ToggleSeedImage(2); SeedSlotOpen = false; }
        }
    }

    public void ToggleSeedImage(int indexToEnable)
    {
        for (int i = 0; i < SeedImage.Length; i++)
        {
            SeedImage[i].SetActive(indexToEnable == i);
            Debug.Log("ToggleSeedImage");
        }
        for (int i = 0; i < SeedHand.Length; i++)
        {
            SeedHand[i].SetActive(indexToEnable == i);
            Debug.Log("ToggleSeedHand");
        }
    }
}