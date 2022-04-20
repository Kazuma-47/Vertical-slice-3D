using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{

    //basic bullet
    public GameObject Normal_Shot;
    //add more bullet prefabs here:
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private float Firerate = 5f;
    private float timer = 0f;
    [SerializeField]
    private float TimerPhaseShot = 0f;
    public GameObject PhaseRound;
    public Transform barel;

    [SerializeField] private GameObject Explosion;
    private void Start()
    {
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        TimerPhaseShot -= Time.deltaTime;
        RaycastHit lookingAt;
        Physics.Raycast(cam.transform.position, cam.transform.forward, out lookingAt, 40f);
        Debug.DrawRay(cam.transform.position, cam.transform.TransformDirection(Vector3.forward) * 40f, Color.yellow);


        if (Input.GetButton("Fire1") && Time.time >= timer)
        {
            timer = Time.time + 1f / Firerate;
            Vector3 Hit = lookingAt.point;
            barel.transform.LookAt(Hit);

            Instantiate(Explosion, Hit, Quaternion.identity, transform);
            //GetComponent<PlayerShoot>().Shoot(Normal_Shot);
            if (lookingAt.collider.GetComponent<EnemyHealthComponent>() != null)
            {
                lookingAt.collider.GetComponent<EnemyHealthComponent>().EnemyTakeDamage(1);
            }
        }
        else if (Input.GetButton("Fire2") && TimerPhaseShot <= 0f)
        {
            Instantiate(PhaseRound, new Vector3(barel.position.x, barel.position.y, barel.position.z), this.gameObject.transform.rotation);
            TimerPhaseShot = 3f;
        }
    }
}
