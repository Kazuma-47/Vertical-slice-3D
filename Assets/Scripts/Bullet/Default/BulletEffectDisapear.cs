using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEffectDisapear : MonoBehaviour
{
    private float _AutoDestroy = 1f;
    //Destroy if it flies out of level bounds
    private void Update()
    {
        _AutoDestroy -= Time.deltaTime;

        if (_AutoDestroy < 0)
        {
            Destroy(gameObject);
        }
    }
}
