using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_UI : MonoBehaviour
{
    public string nameScene;
    public void ClickToPlay()
    {
       SceneManager.LoadScene(nameScene);
       
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
