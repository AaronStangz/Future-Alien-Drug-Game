using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;
using UnityEngine.UIElements;

public class Drop : MonoBehaviour
{
    MainManager MM;
    public GameObject mainManager;

    public GameObject PreSeed1;
    public bool Seed1;
    public GameObject PreSeed2;
    public bool Seed2;
    public GameObject PreSeed3;
    public bool Seed3;

    public Transform Spawn;
    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Seed1) { Instantiate(PreSeed1, Spawn); MM.Seed1 -= 1; }
            if (Seed2) { Instantiate(PreSeed2, Spawn); MM.Seed2 -= 1; }
            if (Seed3) { Instantiate(PreSeed3, Spawn); MM.Seed3 -= 1; }
        }

    }
}

