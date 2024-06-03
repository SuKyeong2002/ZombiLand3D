using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Ctrl : MonoBehaviour
{
    public int enemyScore;

    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = enemyScore.ToString();
    }
}
