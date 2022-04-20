using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject player;
    private string Tag = "Player";
    private Rigidbody rb;
    [HideInInspector]
    public float speed;
    private Animator anim;
    public string State;
    [SerializeField]
    private float TimeToHit = 1f;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag(Tag);
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    //GetComponent<StateManager>().ChangeBehavoir("Found");
    private void Update()
    {
         switch (State)
         { 
             case "OutOfRange" :
             Vector3 PlayerPos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
             transform.LookAt(PlayerPos);
             anim.SetBool("Walking" , true);
             anim.SetBool("Idle" , false);
             anim.SetBool("Attacking" , false);
             rb.velocity = transform.forward * speed;
             break;
            case "InRange":
                TimeToHit -= Time.deltaTime;
                if(TimeToHit <= 0)
                {
                    anim.SetBool("Walking", false);
                    anim.SetBool("Idle", false);
                    anim.SetBool("Attacking", true);
                    rb.velocity = new Vector3(0, 0, 0);
                    TimeToHit = 1f;
                } 
                break;
         } 

    }
}
