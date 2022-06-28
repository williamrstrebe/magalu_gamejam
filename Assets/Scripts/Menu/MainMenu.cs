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

    public void mainMenu()
    {
        Debug.Log("Entrou");
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }

    public void cancel(string room) { 
        SceneManager.LoadScene(room, LoadSceneMode.Single);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }


}
