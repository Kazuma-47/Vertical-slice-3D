using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    /*
    public float speed;
    public float rotationSpeed;
    public float jumpSpeed;
    public CharacterController characterController;

    private float ySpeed;
    private float originalStepOffset; */


    
    public CharacterController Controller;
    public float MovementSpeed = 12f;
    public float Sprong = 1f;
    public float gravity = -10f;
    private float turnSpeed = 0.1f;
    private float smoothVelocity;
    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask GroundMask;
    public Transform Cam;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0f, z).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + Cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, turnSpeed);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 MoveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            Controller.Move(MoveDir * MovementSpeed * Time.deltaTime);
        }

       

        

    }









    /* void Start()
     {
         originalStepOffset = characterController.stepOffset;
     }

     void Update()
     {
         float horizontalInput = Input.GetAxis("Horizontal");
         float verticalInput = Input.GetAxis("Vertical");



         Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
         float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
         movementDirection.Normalize();

         ySpeed += Physics.gravity.y * Time.deltaTime;

         if (characterController.isGrounded)
         {
             characterController.stepOffset = originalStepOffset;
             ySpeed = -0.5f;

             if (Input.GetButtonDown("Jump"))
             {
                 ySpeed = jumpSpeed;
             }
         }
         else
         {
             characterController.stepOffset = 0;
         }

         Vector3 velocity = movementDirection * magnitude;
         velocity.y = ySpeed;

         characterController.Move(velocity * Time.deltaTime);

         if (movementDirection != Vector3.zero)
         {
             Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

             transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
         }*/

}