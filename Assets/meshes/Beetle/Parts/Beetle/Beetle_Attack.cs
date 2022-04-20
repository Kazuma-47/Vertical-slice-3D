using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beetle_Attack : MonoBehaviour
{
    private float biteRange =4f;
    [SerializeField] private LayerMask _layer;
    public void Beetle_Bite()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, biteRange, _layer);
        foreach (var Hit in cols)
        {
            Hit.GetComponent<healthComponent>().TakeDamage(1);
        }
    }
}
