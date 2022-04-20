using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBullet : MonoBehaviour
{
    public GameObject FireBall_Bullet;
    private Animator anim;
    public GameObject Rotation;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void ShootBullet()
    {
        GameObject bullet = Instantiate(FireBall_Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Rotation.transform.rotation);
        anim.SetBool("Shoot", false);

    }
}
