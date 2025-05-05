using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductDealerUI : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;
    [Space]
    public GameObject mainCamera;
    PlayerCam MC;

    public GameObject player;
    Inventory INV;

    public GameObject GUI;
    public GameObject ProductDealerTab;

    public bool UIOpen;

    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
        GUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && UIOpen)
        {
            UIOpen = false;
            GUI.SetActive(false);
            ProductDealerTab.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            gameObject.GetComponent<PlayerMovement>().enabled = true;
            MC.enabled = true;
        }
    }

    public void Open()
    {
        MC = gameObject.GetComponent<PlayerCam>();
        INV = gameObject.GetComponent<Inventory>();

        UIOpen = true;
        INV.Open();
        GUI.SetActive(true);
        ProductDealerTab.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        gameObject.GetComponent<PlayerMovement>().enabled = false;
        MC.enabled = false;
    }
}
