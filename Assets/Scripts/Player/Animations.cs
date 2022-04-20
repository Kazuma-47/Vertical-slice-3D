using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator animator;
    private float yPosition;

    // Start is called before the first frame update
    void Start()
    {
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Run Check

        if (Input.GetKey("w") | Input.GetKey("a") | Input.GetKey("s") | Input.GetKey("d"))
        {
            Run();
        } else
        {
            animator.SetBool("running", false);
        }

        // Jump Check
        if (Input.GetKeyDown(KeyCode.Space))
        {
            yPosition = transform.position.y;
            Jump();
        }
        else if (transform.position.y < yPosition) {
            animator.SetBool("jumping", false);
        }

        // Slide Check
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Slide();
        } else
        {
            animator.SetBool("sliding", false);
        }

    }


    void Run()
    {
        animator.SetBool("running",  true);
      //animator.SetBool("jumping", false);
        animator.SetBool("sliding", false);

    }

    void Jump()
    {
        animator.SetBool("running", false);
        animator.SetBool("jumping",  true);
        animator.SetBool("sliding", false);
    }

    void Slide()
    {
        animator.SetBool("running", false);
        animator.SetBool("jumping", false);
        animator.SetBool("sliding",  true);
    }

}
