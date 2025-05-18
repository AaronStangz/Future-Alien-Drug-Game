using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
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

    public string CronaSeedName = "CronaSeedHand";
    public string TwertaSeedName = "TwertaSeedHand";
    public string PlaronSeedName = "PlaronSeedHand";

    void Start()
    {
        Hand = GameObject.Find("Hand");
        CronaSeedHand = GameObject.Find(CronaSeedName);
        TwertaSeedHand = GameObject.Find(TwertaSeedName);
        PlaronSeedHand = GameObject.Find(PlaronSeedName);
    }

    void Update()
    {
        // Fix: Don't check the same object three times.
        if (Hand == null || CronaSeedHand == null || TwertaSeedHand == null || PlaronSeedHand == null)
        {
            FindAll();
        }
    }

    public void FindAll()
    {
        Hand = FindInactiveObject("Hand");
        CronaSeedHand = FindInactiveObject(CronaSeedName);
        TwertaSeedHand = FindInactiveObject(TwertaSeedName);
        PlaronSeedHand = FindInactiveObject(PlaronSeedName);
    }

    public static GameObject FindInactiveObject(string objectName)
    {
        GameObject[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj.name == objectName &&
                !obj.hideFlags.HasFlag(HideFlags.NotEditable) &&
                !obj.hideFlags.HasFlag(HideFlags.HideAndDontSave))
            {
                return obj;
            }
        }
        return null;
    }

    public void Plant()
    {
        PlantSeed(CronaSeedHand, Crona, "Crona");
        PlantSeed(TwertaSeedHand, Twerta, "Twerta");
        PlantSeed(PlaronSeedHand, Plaron, "Plaron");

    }

    private void PlantSeed(GameObject seedHand, GameObject plant, string plantName)
    {
        if (seedHand != null && seedHand.activeSelf && plant != null)
        {
            plant.SetActive(true);
            Debug.Log($"{plantName} planted");

            if (Hand != null)
            {
                foreach (Transform child in Hand.transform)
                {
                    child.gameObject.SetActive(false);
                }
            }
        }
    }
}

