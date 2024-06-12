using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButton_Ctrl : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("StartGame");
    }

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        
    }
}
