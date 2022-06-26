using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour

{
    Vector3 mousePositionOffset;
    public GameObject correctPlace;
    bool finished;

    private void Start()
    {
        finished = false;
    }
    private Vector3 GetMouseWorldPosition()
    {

        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        if (!finished)
            mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        if (!finished)
            transform.position = GetMouseWorldPosition() + mousePositionOffset;

    }

    private void OnMouseUp()
    {
        if (!finished)
            if ((Mathf.Abs(this.transform.localPosition.x - correctPlace.transform.localPosition.x) <= 5f)
                && (Mathf.Abs(this.transform.localPosition.y - correctPlace.transform.localPosition.y) <= 5f))
            {
                this.transform.position = new Vector3(correctPlace.transform.position.x, correctPlace.transform.position.y, correctPlace.transform.position.z);
                finished = true;

                foreach (JigsawController obj in FindObjectsOfType<JigsawController>())
                {
                    obj.pieceAttached();
                }
                Debug.Log("attachou peça");
            }

    }
}
