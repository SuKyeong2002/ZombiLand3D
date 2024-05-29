using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombi2_Move : MonoBehaviour
{
    Transform playerPos;
    float dist;
    float detectDist = 20.0f;
    int shotCnt = 0;
    public GameObject pfDestroyFx;

    void Start()
    {
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        dist = Vector3.Distance(playerPos.position, transform.position);

        if (dist < detectDist)
        {
            GetComponent<Animator>().SetBool("isWalk", true);
            GetComponent<NavMeshAgent>().SetDestination(playerPos.position);
        }
        else if (dist > detectDist)
        {
            GetComponent<Animator>().SetBool("isWalk", false);
            GetComponent<NavMeshAgent>().SetDestination(transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            shotCnt += 1;
            GetComponent<AudioSource>().Play();
            if (shotCnt == 3)
            {
                gameObject.SetActive(false);
                Destroy(other.gameObject);
                shotCnt = 0;
                Instantiate(pfDestroyFx, transform.position, transform.rotation);
            }
        }
    }
}
