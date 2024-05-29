using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot_Ctrl : MonoBehaviour
{
    public GameObject pfBullet;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pfBullet, transform.position, transform.rotation);
        }
    }
}
