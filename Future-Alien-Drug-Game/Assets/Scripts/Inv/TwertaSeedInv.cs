using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwertaSeedInv : MonoBehaviour
{
    public GameObject TwertaSeedHandObj;
    //public GameObject Hand;

    public string TwertaSeedName = " TwertaSeedHand"; // <- The name of the item you're looking for

    void Start()
    {
        Find(TwertaSeedName);
    }

    void Update()
    {
        if (TwertaSeedHandObj == null)
        {
            Find(TwertaSeedName);
        }
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

    public void Hold(string objectName)
    {
        Action();
    }

    public void Find(string objectName)
    {
        TwertaSeedHandObj = FindInactiveObject(TwertaSeedName);
    }

    public void Action()
    {
        if (TwertaSeedHandObj != null)
        {
            Debug.Log("Holding");
            TwertaSeedHandObj.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Hand or  TwertaSeedHandObj not found.");
        }
    }
}