using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTarget : MonoBehaviour { 

    private Rigidbody rb;
    [SerializeField]
    private float speed = 20f;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
     void Start()
    { 
        rb.velocity = transform.forward * speed;

    }

}
