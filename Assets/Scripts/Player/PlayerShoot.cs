using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform barel;
    public void Shoot(GameObject SelectedBullet)
    {
        GameObject bullet = Instantiate(SelectedBullet, new Vector3(barel.position.x, barel.position.y, barel.position.z), this.gameObject.transform.rotation);

    }
}
