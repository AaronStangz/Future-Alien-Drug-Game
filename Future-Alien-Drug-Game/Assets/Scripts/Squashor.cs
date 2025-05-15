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
    public bool BottledTwertapopRunning;
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

    public void BottledTwertapopST()
    {
        if (MM.Twertapop >= 1 && MM.Bottle >= 1 && !BottledTwertapopRunning ) StartCoroutine(BottledTwertapopTimer());
        Debug.Log("Start");
    }
    IEnumerator BottledTwertapopTimer()
    {
        float Ttimer = 0;
        BottledTwertapopRunning = true;

        MM.Bottle -= 1;
        MM.Twertapop -= 1;

        while (Ttimer < BottleTwertapopTime)
        {
            Ttimer += Time.deltaTime;

            float realValue = Ttimer / BottleTwertapopTime;
            BottleTwertapopSlider.value = realValue; 
            yield return null;
        }
        BottledTwertapopRunning = false;
        BottledTwertapop();
    }
    public void BottledTwertapop()
    {
            MM.BottledTwertapop += 1;
    }

    public void BottledPlaronlossST()
    {
        if (MM.Plaronloss >= 1 && MM.Bottle >= 1 && !BottledPlaronlossRunning) StartCoroutine(BottledPlaronlossTimer());
        Debug.Log("Start");
    }
    IEnumerator BottledPlaronlossTimer()
    {
        float Ptimer = 0;
        BottledPlaronlossRunning = true;

        MM.Bottle -= 1;
        MM.Plaronloss -= 1;

        while (Ptimer < BottleTwertapopTime)
        {
            Ptimer += Time.deltaTime;

            float realValue = Ptimer / BottlePlaronlossTime;
            BottlePlaronlossSlider.value = realValue; 
            yield return null;
        }
        BottledPlaronlossRunning = false;
        BottledPlaronloss();
    }
    public void BottledPlaronloss()
    {
            MM.BottledPlaronloss += 1;
    }

}
