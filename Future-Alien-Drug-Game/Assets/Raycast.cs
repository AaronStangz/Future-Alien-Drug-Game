using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask Interactable;
    [SerializeField] private LayerMask Collectable;
    [SerializeField] private LayerMask Built;
    [SerializeField] private LayerMask Hub;

    MainManager IM;
    public GameObject mainManager;
    public GameObject player;

    void Start()
    {
        IM = mainManager.GetComponent<MainManager>();

    }

    void Update()
    {
        if (Camera.main == null) return;

        RaycastHit hit;

        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 1000);
        if (Physics.SphereCast(ray, 0.5f, out hit, 10, Interactable + Collectable + Built + Hub))
        {
            if (Interactable.value == (1 << hit.collider.gameObject.layer))
            {

                Squashor Sq = hit.collider.GetComponent<Squashor>();
                if (Sq != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < Sq.openRange)
                        {
                            Debug.Log("Open");
                            Sq.Open();
                        }
                    }
                }

               

            }

            if (Interactable.value == (1 << hit.collider.gameObject.layer))
            {

                Radiator Ra = hit.collider.GetComponent<Radiator>();
                if (Ra != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < Ra.openRange)
                        {
                            Debug.Log("Open");
                            Ra.Open();
                        }
                    }
                }
            }

            if (Interactable.value == (1 << hit.collider.gameObject.layer))
            {

                GunLocker GL = hit.collider.GetComponent<GunLocker>();
                if (GL != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < GL.openRange)
                        {
                            Debug.Log("Open");
                            GL.Open();
                        }
                    }
                }
            }

            if (Interactable.value == (1 << hit.collider.gameObject.layer))
            {

                WeaponLocker WL = hit.collider.GetComponent<WeaponLocker>();
                if (WL != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < WL.openRange)
                        {
                            Debug.Log("Open");
                            WL.Open();
                        }
                    }
                }
            }

            if (Collectable.value == (1 << hit.collider.gameObject.layer))
            {

                Collect CO = hit.collider.GetComponent<Collect>();
                if (CO != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < CO.pickUpRange)
                        {
                            Debug.Log("Open");
                            CO.CollectItem();
                        }
                    }
                }
            }
        }
    }
}
