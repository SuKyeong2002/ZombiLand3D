using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton_Ctrl : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("StartGame");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
