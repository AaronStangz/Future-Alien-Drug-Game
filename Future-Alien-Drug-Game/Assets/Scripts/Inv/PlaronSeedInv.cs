using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaronSeedInv : MonoBehaviour, IPointerClickHandler
{
    public GameObject PlaronSeedHandObj;

    public GameObject PlaronSeedHandPre;

    public GameObject mainManager;
    MainManager MM;

    //public GameObject Hand;

    public string PlaronSeedName = " PlaronSeedHand"; // <- The name of the item you're looking for

    void Start()
    {
        Find(PlaronSeedName);

    }

    void Update()
    {
        if (PlaronSeedHandObj == null && MM == null)
        {
            Find(PlaronSeedName);

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
        PlaronSeedHandObj = FindInactiveObject(PlaronSeedName);
        mainManager = GameObject.Find("Main Manager");
        MM = mainManager.GetComponent<MainManager>();
    }

    public void Action()
    {
        if (PlaronSeedHandObj != null)
        {
            Debug.Log("Holding");
            PlaronSeedHandObj.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Hand or  PlaronSeedHandObj not found.");
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log(name + " Game Object Right Clicked!");
            Drop();
        }

        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log(name + " Game Object Left Clicked!");
            Hold(PlaronSeedName);
        }
    }


    public void Drop()
    { 
        Destroy(gameObject);
    }
}