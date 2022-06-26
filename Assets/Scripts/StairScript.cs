using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairScript : MonoBehaviour
{

    public void goTo(string scene) {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
