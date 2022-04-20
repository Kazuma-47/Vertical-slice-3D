using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnim : MonoBehaviour
{

    public void Death()
    {
        Destroy(gameObject, 0.5f);
    }
    public void Move()
    {
        GetComponent<EnemyMovement>().speed = 0f;
    }
}
