using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareObserver : MonoBehaviour
{

    public string myJigsaw;
    private string currentJigsaw;

    private void Start()
    {
        Debug.Log(myJigsaw);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }


}
