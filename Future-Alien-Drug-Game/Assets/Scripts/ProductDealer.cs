using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductDealer : MonoBehaviour
{
    public GameObject productDealerUI;
    ProductDealerUI PD;

    public int openRange;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Open()
    {
        productDealerUI = GameObject.Find("Player");
        PD = productDealerUI.GetComponent<ProductDealerUI>();
        PD.Open();
    }

}
