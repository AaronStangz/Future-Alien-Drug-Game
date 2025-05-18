using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Squashor : MonoBehaviour
{
    public GameObject mainManager;
    public GameObject Player;
    MainManager MM;
    [Space]
    public GameObject mainCamera;
    PlayerCam PC;

    Inventory INV;

    public GameObject GUI;

    public bool BottleCronaleanRunning;
    public bool BottleTwertapopRunning;
    public bool BottledPlaronlossRunning;

    public float BottleCronaleanTime;
    public Slider BottleCronaleanSlider;

    public float BottleTwertapopTime;
    public Slider BottleTwertapopSlider;

    public float BottlePlaronlossTime;
    public Slider BottlePlaronlossSlider;

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
            Player.GetComponent<PlayerMovement>().enabled = true;
            //PC.enabled = true;
        }
    }

    public void Open()
    {
        UIOpen = true;
        //INV.Open();
        GUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Player.GetComponent<PlayerMovement>().enabled = false;
        //PC.enabled = false;
    }


    public void BottleCronaleanST()
    {
        if (MM.Cronalean >= 1 && MM.Bottle >= 1 && !BottleCronaleanRunning) StartCoroutine(BottleCronaleanTimer());
        Debug.Log("Start");
    }
    IEnumerator BottleCronaleanTimer()
    {
         float Ctimer = 0;
        BottleCronaleanRunning = true;

        MM.Bottle -= 1;
        MM.Cronalean -= 1;

        while (Ctimer < BottleCronaleanTime)
        {
            Ctimer += Time.deltaTime;

            float realValue = Ctimer / BottleCronaleanTime;
            BottleCronaleanSlider.value = realValue; 
            yield return null;
        }
        BottleCronaleanRunning = false;
        BottleCronalean();
    }
    public void BottleCronalean()
    {
            MM.BottledCronalean += 1;
    }

    public void BottleTwertapopST()
    {
        if (MM.Twertapop >= 1 && MM.Bottle >= 1 && !BottleTwertapopRunning ) StartCoroutine(BottleTwertapopTimer());
        Debug.Log("Start");
    }
    IEnumerator BottleTwertapopTimer()
    {
        float Ttimer = 0;
        BottleTwertapopRunning = true;

        MM.Bottle -= 1;
        MM.Twertapop -= 1;

        while (Ttimer < BottleTwertapopTime)
        {
            Ttimer += Time.deltaTime;

            float realValue = Ttimer / BottleTwertapopTime;
            BottleTwertapopSlider.value = realValue; 
            yield return null;
        }
        BottleTwertapopRunning = false;
        BottleTwertapop();
    }
    public void BottleTwertapop()
    {
            MM.BottledTwertapop += 1;
    }

    public void BottlePlaronlossST()
    {
        if (MM.Twertapop >= 1 && MM.Bottle >= 1 && !BottledPlaronlossRunning) StartCoroutine(BottlePlaronlossTimer());
        Debug.Log("Start");
    }
    IEnumerator BottlePlaronlossTimer()
    {
        float Ttimer = 0;
        BottledPlaronlossRunning = true;

        MM.Bottle -= 1;
        MM.Twertapop -= 1;

        while (Ttimer < BottlePlaronlossTime)
        {
            Ttimer += Time.deltaTime;

            float realValue = Ttimer / BottlePlaronlossTime;
            BottlePlaronlossSlider.value = realValue;
            yield return null;
        }
        BottledPlaronlossRunning = false;
        BottlePlaronloss();
    }
    public void BottlePlaronloss()
    {
        MM.BottledPlaronloss += 1;
    }

}
