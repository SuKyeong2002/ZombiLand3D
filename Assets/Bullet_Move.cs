using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Move : MonoBehaviour
{
    float speed = 5000f;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
        Destroy(gameObject, 3.0f);
    }

    void Update()
    {
        
    }
}
