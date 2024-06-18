using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombi_Move : MonoBehaviour
{
    Transform playerPos;
    float dist;
    float detectDist = 20.0f;

    void Start()
    {
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        dist = Vector3.Distance(playerPos.position, transform.position);

        if(dist < detectDist)
        {
            GetComponent<Animator>().SetBool("isWalk", true);
            GetComponent<NavMeshAgent>().SetDestination(playerPos.position);
        } else if (dist > detectDist)
        {
            GetComponent<Animator>().SetBool("isWalk", false);
            GetComponent<NavMeshAgent>().SetDestination(transform.position);
        }
    }
}
