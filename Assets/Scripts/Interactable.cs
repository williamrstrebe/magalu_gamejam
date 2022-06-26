using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{

    public KeyCode interactKey;
    public UnityEvent interactAction;
    private bool inRange;
   
    private void Update()
    {
        if (inRange)
            if (Input.GetKeyDown(interactKey))
                interactAction.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("InRange");
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = true;
            //canvas.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            Debug.Log("OutOfRange");
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = false;
            //canvas.enabled = false;
        }

    }

}
