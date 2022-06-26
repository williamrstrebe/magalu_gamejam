using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JigsawController : MonoBehaviour

{
    public int piecesLeft;
    // Start is called before the first frame update
    void Start()
    {
        piecesLeft = 12;       
    }
    public void pieceAttached() {
        this.piecesLeft--;

        Debug.Log("peças sobrando"+piecesLeft);

        if (piecesLeft == 0) { 
            Debug.Log("Venceu!");

            // concluir nivel
            SceneManager.LoadScene("FirstFloor", LoadSceneMode.Single);
        }



    }
}
