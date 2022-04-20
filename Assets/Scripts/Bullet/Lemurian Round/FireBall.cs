using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private float _AutoDestroy = 5f;

    //Destroy if it flies out of level bounds
    private void Update()
    {
        _AutoDestroy -= Time.deltaTime;

        if (_AutoDestroy < 0)
        {
            Destroy(gameObject);
        }
    }



    //Destroy on collsion with other objects

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.GetComponent<healthComponent>().TakeDamage(1);
            Destroy(gameObject);
        }
        else if (collision.transform.tag == "Environment")
        {
            Destroy(gameObject);
        }
    }
}
