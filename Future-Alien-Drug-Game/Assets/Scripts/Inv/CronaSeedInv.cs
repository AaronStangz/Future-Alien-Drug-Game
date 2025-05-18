using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CronaSeedInv : MonoBehaviour
{
    public GameObject CronaSeedHandObj;
    //public GameObject Hand;

    public string CronaSeedName = "CronaSeedHand"; // <- The name of the item you're looking for

    void Start()
    {
        Find(CronaSeedName);
    }

    void Update()
    {
        if (CronaSeedHandObj == null)
        {
            Find(CronaSeedName);
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
        CronaSeedHandObj = FindInactiveObject(CronaSeedName);
    }

    public void Action()
    {
        if (CronaSeedHandObj != null)
        {
            Debug.Log("Holding");
            CronaSeedHandObj.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Hand or CronaSeedHandObj not found.");
        }
    }
}

