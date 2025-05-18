using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Inventory : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    public GameObject mainCamera;
    PlayerCam MC;

    public GameObject GUI;
    public GameObject Hand;
    public GameObject Pad;
    public GameObject Player;
    public bool UIOpen;

    public Transform Content;

    public GameObject CronaSeed;
    public GameObject PlaronSeed;
    public GameObject TwertaSeed;

    public GameObject Bottle;

    public GameObject Cronalean;
    public GameObject Twertapop;
    public GameObject Plaronloss;

    public GameObject BottledCronalean;
    public GameObject BottledTwertapop;
    public GameObject BottledPlaronloss;

    [System.Serializable]
    public class InventoryItem
    {
        public string tag;
        public GameObject prefab;
        public int previousAmount;
        public System.Func<int> GetAmount;
    }

    public List<InventoryItem> items = new List<InventoryItem>();

    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
        MC = mainCamera.GetComponent<PlayerCam>();
        GUI.SetActive(false);

        items.Add(new InventoryItem
        {
            tag = "CronaSeed",
            prefab = CronaSeed,
            GetAmount = () => MM.CronaSeed
        });
        items.Add(new InventoryItem
        {
            tag = "PlaronSeed",
            prefab = PlaronSeed,
            GetAmount = () => MM.PlaronSeed
        });
        items.Add(new InventoryItem
        {
            tag = "TwertaSeed",
            prefab = TwertaSeed,
            GetAmount = () => MM.TwertaSeed
        });

        items.Add(new InventoryItem
        {
            tag = "Bottle",
            prefab = Bottle,
            GetAmount = () => MM.Bottle
        });

        items.Add(new InventoryItem
        {
            tag = "Cronalean",
            prefab = Cronalean,
            GetAmount = () => MM.Cronalean
        });
        items.Add(new InventoryItem
        {
            tag = "Twertapop",
            prefab = Twertapop,
            GetAmount = () => MM.Twertapop
        });
        items.Add(new InventoryItem
        {
            tag = "Plaronloss",
            prefab = Plaronloss,
            GetAmount = () => MM.Plaronloss
        });

        items.Add(new InventoryItem
        {
            tag = "BottledCronalean",
            prefab = BottledCronalean,
            GetAmount = () => MM.BottledCronalean
        });
        items.Add(new InventoryItem
        {
            tag = "BottledTwertapop",
            prefab = BottledTwertapop,
            GetAmount = () => MM.BottledTwertapop
        });
        items.Add(new InventoryItem
        {
            tag = "BottledPlaronloss",
            prefab = BottledPlaronloss,
            GetAmount = () => MM.BottledPlaronloss
        });

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && UIOpen)
        {
            Close();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Open();
        }

        foreach (var item in items)
        {
            if (item.GetAmount == null)
            {
                Debug.LogWarning($"GetAmount function is null for item with tag: {item.tag}");
                continue;
            }

            int current = item.GetAmount();

            if (current > item.previousAmount)
            {
                Instantiate(item.prefab, Content).tag = item.tag;
            }
            else if (current < item.previousAmount)
            {
                RemoveItem(item.tag);
            }

            item.previousAmount = current;
        }
    }

    public void RemoveItem(string tagname)
    {
        for (int i = 0; i < Content.childCount; i++)
        {
            Transform child = Content.GetChild(i);
            if (child.tag == tagname)
            {
                Destroy(child.gameObject);
                return;
            }
        }
    }

    public void Open()
    {
        UIOpen = true;
        Pad.SetActive(true);
        GUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        MC.enabled = false;

        foreach (Transform child in Hand.transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void Close()
    {
        UIOpen = false;
        GUI.SetActive(false);
        Pad.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        MC.enabled = true;
    }
}
