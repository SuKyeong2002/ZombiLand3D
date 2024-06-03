using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPgage_Ctrl : MonoBehaviour
{

    public float hpGage = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Image>().fillAmount = hpGage;
    }
}
