using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Girlfriend_Move : MonoBehaviour
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

        if (dist < detectDist)
        {
            GetComponent<Animator>().SetBool("isHelp", true);
            GetComponent<NavMeshAgent>().SetDestination(playerPos.position);
        }
        else if (dist > detectDist)
        {
            GetComponent<Animator>().SetBool("isHelp", false);
            GetComponent<NavMeshAgent>().SetDestination(transform.position);
        }
    }
}
