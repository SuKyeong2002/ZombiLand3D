using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessButton_Ctrl : MonoBehaviour
{
    public void SuccessGame()
    {
        SceneManager.LoadScene("Main");
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
