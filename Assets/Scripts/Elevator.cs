using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    [SerializeField] private Transform destination;

    public Transform GetDestination()
    {
        return destination;
    }
}
