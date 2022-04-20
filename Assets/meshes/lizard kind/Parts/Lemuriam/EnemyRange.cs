using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemurian_Agro : MonoBehaviour
{
    public float _AgroRange;
    private string Tag = "Player";


    private void Start()
    {

    }
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag(Tag);
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer <= _AgroRange)
        {
            GetComponent<EnemyMovement>().State = "InRange";
            GetComponentInChildren<Lemurian_Attack>().enabled = true;
            GetComponentInChildren<TrackPlayer>().enabled = true;
        }
        else if (distanceToPlayer >= _AgroRange)
        {
            GetComponent<EnemyMovement>().State = "OutOfRange";
            GetComponentInChildren<Lemurian_Attack>().enabled = false;
            GetComponentInChildren<TrackPlayer>().enabled = false;
        }
    }
}
