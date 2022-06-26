using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Bedroom", LoadSceneMode.Single);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }


}
