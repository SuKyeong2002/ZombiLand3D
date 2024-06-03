using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Move : MonoBehaviour
{
    float speed = 5000f;
    Score_Ctrl score;

    void Start()
    {
        score = GameObject.Find("ScoreText").GetComponent<Score_Ctrl>();
        GetComponent<Rigidbody>().AddForce(transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
        Destroy(gameObject, 3.0f);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag  == "Zombi")
        {
            score.enemyScore = score.enemyScore + 10;
        }
    }
}
