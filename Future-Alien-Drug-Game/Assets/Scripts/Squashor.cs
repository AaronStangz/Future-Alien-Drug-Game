using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squashor : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;
    [Space]
    public GameObject mainCamera;
    PlayerCam PC;

    Inventory INV;

    public GameObject GUI;

    public int openRange;
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
            Cursor.lockState = CursorLockMode.Locked;
            gameObject.GetComponent<PlayerMovement>().enabled = true;
            PC.enabled = true;
        }
    }

    public void Open()
    {
        UIOpen = true;
        INV.Open();
        GUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        gameObject.GetComponent<PlayerMovement>().enabled = false;
        PC.enabled = false;
    }
}
