using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Transform destinationPoint;


    private void Update()
    {
        transform.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = destinationPoint.position;
    }
}
