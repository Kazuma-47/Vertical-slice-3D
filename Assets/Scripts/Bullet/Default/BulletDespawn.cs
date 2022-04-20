using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : MonoBehaviour
{
    private float _AutoDestroy = 5f;
    public GameObject Explosion;


    //Destroy if it flies out of level bounds
    private void Update()
    {
        _AutoDestroy -= Time.deltaTime;

        if(_AutoDestroy < 0)
        {
            Destroy(gameObject);
        }
    }



    //Destroy on collsion with other objects

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity );
            Destroy(gameObject);
        }
        else if (collision.transform.tag == "Environment")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity );
            Destroy(gameObject);
        }
    }
}
