using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaronlossInv : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;
    public GameObject Player;
    Inventory Inv;

    void Start()
    {
        mainManager = GameObject.Find("Main Manager");
        MM = mainManager.GetComponent<MainManager>();
        Player = GameObject.Find("Player");
        Inv = Player.GetComponent<Inventory>();
    }

    void Update()
    {

    }
}
