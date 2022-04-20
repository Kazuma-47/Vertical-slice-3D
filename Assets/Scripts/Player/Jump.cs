using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int force;

    private bool canJump;
    public Rigidbody selfRigidbody;

    void Start()
    {
    }

    void FixedUpdate()
    {
        if (canJump)
        {
            canJump = false;
            selfRigidbody.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            canJump = true;
        }
    }
}
