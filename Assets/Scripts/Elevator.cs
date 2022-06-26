using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void moveUp() {
        Vector3 pos = player.transform.position;
        player.transform.position = new Vector3(pos.x, pos.y+6, pos.z);
    
    }
}
