using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronaSeedInv : MonoBehaviour
{
    public GameObject CronaSeedHand;
    public GameObject Hand;

    public GameObject mainManager;
    MainManager MM;

    void Start()
    {
        mainManager = GameObject.Find("Main Manager");
        Hand = FindInactiveObject("Hand");
    }

    void Update()
    {

    }

    public static GameObject FindInactiveObject(string name)
    {
        GameObject[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj.name == name && !obj.hideFlags.HasFlag(HideFlags.NotEditable) && !obj.hideFlags.HasFlag(HideFlags.HideAndDontSave))
            {
                return obj;
            }
        }
        return null;
    }

    public void Hold()
    {
        print("Holding");
        CronaSeedHand = FindInactiveObject("CronaSeedHand");
        MM = mainManager.GetComponent<MainManager>();
        if (CronaSeedHand != null)
        {
            MM.CronaSeed -= 1;
            Hand.SetActive(true);
            CronaSeedHand.SetActive(true);
        }
    }
}
