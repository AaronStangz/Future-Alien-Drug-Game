using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class Grower : MonoBehaviour
{
    public GameObject Hand;
    public GameObject CronaSeedHand;
    public GameObject TwertaSeedHand;
    public GameObject PlaronSeedHand;

    public GameObject Crona;
    public GameObject Twerta;
    public GameObject Plaron;

    public float Range;
    void Start()
    {
        Hand = GameObject.Find("Hand");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Plant()
    {
        Hand.SetActive(false);

        CronaSeedHand = GameObject.Find("CronaSeedHand");
        TwertaSeedHand = GameObject.Find("TwertaSeedHand");
        PlaronSeedHand = GameObject.Find("PlaronSeedHand");
        Hand.SetActive(false);

        Crona.SetActive(true);

        if (CronaSeedHand != null && CronaSeedHand)
        {
            Crona.SetActive(true);
            print("sssssssssssssssssdf");
        }
        if (TwertaSeedHand != null && TwertaSeedHand)
        {
            Twerta.SetActive(true);
        }
        if (PlaronSeedHand != null && PlaronSeedHand)
        {
            Plaron.SetActive(true);
        }
    }
}
