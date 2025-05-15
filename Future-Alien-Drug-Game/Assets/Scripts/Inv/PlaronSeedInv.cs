using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaronSeedInv : MonoBehaviour
{
    public GameObject PlaronSeedHand;
    public GameObject Hand;

    void Start()
    {
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
        PlaronSeedHand = FindInactiveObject("PlaronSeedHand");
        if (PlaronSeedHand != null)
        {
            Hand.SetActive(true);
            PlaronSeedHand.SetActive(true);
        }
    }
}
