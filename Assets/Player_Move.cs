using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Move : MonoBehaviour
{
    HPgage_Ctrl damage;

    void Start()
    {
        damage = GameObject.Find("HPgage").GetComponent<HPgage_Ctrl>();
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zombi")
        {
            damage.hpGage -= 0.2f;
            if (damage.hpGage <= 0.0f)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("EndGame");
            }
        }
    }
}
