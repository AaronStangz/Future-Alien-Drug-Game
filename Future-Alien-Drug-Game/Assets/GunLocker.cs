using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLocker : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;
    [Space]
    public GameObject mainCamera;
    PlayerCam PC;

    public GameObject GUI;
    public GameObject Player;

    public GameObject PistolButton;
    public GameObject RevolverlButton;
    public GameObject TeaserButton;

    public GameObject[] GunEqupit;
    [Space]

    public int openRange;
    public bool UIOpen;


    void Start()
    {
        Player = GameObject.Find("Player");
        GUI = GameObject.Find("GunLockerUI");

        mainManager = GameObject.Find("Main Manager");
        mainCamera = GameObject.Find("Main Camera");

        PistolButton = GameObject.Find("PistolLB");
        RevolverlButton = GameObject.Find("RevolverlLB");
        TeaserButton = GameObject.Find("TeaserLB");

        MM = mainManager.GetComponent<MainManager>();
        PC = mainCamera.GetComponent<PlayerCam>();
        GUI.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Escape) && UIOpen)
        {
            UIOpen = false;
            GUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Player.GetComponent<PlayerMovement>().enabled = true;
            PC.enabled = true;
        }

        if(UIOpen == true) 
        {
            if(MM.Pistol == 1) { PistolButton.SetActive(true); }
            if (MM.Pistol == 0) { PistolButton.SetActive(false); }
            if (MM.Revolver == 1) { RevolverlButton.SetActive(true); }
            if (MM.Revolver == 0) { RevolverlButton.SetActive(false); }
            if (MM.Teaser == 1) { TeaserButton.SetActive(true); }
            if (MM.Teaser == 0) { TeaserButton.SetActive(false); }
        }
    }

    public void Open()
    {
        UIOpen = true;
        GUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Player.GetComponent<PlayerMovement>().enabled = false;
        PC.enabled = false;
    }

    public void ToggleGun(int indexToEnable)
    {
        for (int i = 0; i < GunEqupit.Length; i++)
        {
            GunEqupit[i].SetActive(indexToEnable == i);
            Debug.Log("ToggleTeirPage");
        }
    }
}
