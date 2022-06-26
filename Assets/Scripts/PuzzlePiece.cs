using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour, IPointerClickHandler
{
    private int multiplier;
    private void Start()
    {
        multiplier = 0;
    }
    [ContextMenu("asdasd")]
    public void rotate()
    {

        Debug.Log("Rotation");

        multiplier += 1;

        float rot = 0;
        if (multiplier == 1)
            rot = -90f;
        if (multiplier == 2)
            rot = -180;
        if (multiplier == 3)
            rot = -270;
        if (multiplier == 4) { 
            rot = 0;
            multiplier = 0;
        }
        transform.Rotate(0, 0, rot);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(name + " Game Object Clicked!");
    }
}
