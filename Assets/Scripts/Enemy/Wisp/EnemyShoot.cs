using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyShoot : MonoBehaviour
{
    public Transform Player;
    public float _Timer;
    [HideInInspector]
    public TrackPlayer trackPlayer;
    private float range = 20f;
    [SerializeField]
    private LayerMask PlayerMask = new LayerMask();

    private healthComponent enemyHealth = null;
    private void Start()
    {
        
        _Timer = 5f;
        trackPlayer= GetComponent<TrackPlayer>();
    }

    private void Update()
    {
        Player = trackPlayer.PlayerLocation;
        _Timer -= Time.deltaTime;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * range, Color.yellow);


        if (_Timer < 1f && _Timer > 0.5f ) 
        {
            //Play charge animation
            gameObject.transform.GetComponent<TrackPlayer>().enabled = false;
        }
        if (_Timer <= 0f)
        {
            RaycastHit hit;
            healthComponent HitObject = null;
            if (Physics.Raycast(transform.position, transform.forward, out hit, range ,PlayerMask))
            {
                    HitObject = hit.transform.GetComponent<healthComponent>();
                    if(HitObject != null)
                    {
                        //Player take damage
                        HitObject.TakeDamage(1);
                    }
            }

            gameObject.transform.GetComponent<TrackPlayer>().enabled = true;
            _Timer = 3f;
        }
    }
}
