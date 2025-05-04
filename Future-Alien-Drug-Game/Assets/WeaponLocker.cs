using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLocker : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;
    [Space]
    public GameObject mainCamera;
    PlayerCam PC;

    public GameObject GUI;
    public GameObject Player;

    public int openRange;
    public bool UIOpen;

    void Start()
    {
        Player = GameObject.Find("Player");
        GUI = GameObject.Find("WeaponLockerUI");
        mainManager = GameObject.Find("Main Manager");
        mainCamera = GameObject.Find("Main Camera");
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
    }

    public void Open()
    {
        UIOpen = true;
        GUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Player.GetComponent<PlayerMovement>().enabled = false;
        PC.enabled = false;
    }
}
