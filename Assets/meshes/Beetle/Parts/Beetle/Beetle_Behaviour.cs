using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beetle_Behaviour : MonoBehaviour
{
    [HideInInspector]
    private GameObject player;
    private string Tag = "Player";
    private EnemyMovement Movement;
    public float AttackRange;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag(Tag);
        Movement = GetComponent<EnemyMovement>();
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if(distanceToPlayer < AttackRange)
        {
            Movement.State = "InRange";
        }
        else if (distanceToPlayer > AttackRange)
        {
            Movement.State = "OutOfRange";
        }
    }
   
}

