using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairScript : MonoBehaviour
{

    public void goToHotel() {
        SceneManager.LoadScene("Hotel", LoadSceneMode.Single);
    }
}
