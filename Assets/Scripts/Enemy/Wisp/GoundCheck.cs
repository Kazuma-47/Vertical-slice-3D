using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoundCheck : MonoBehaviour
{
    [SerializeField]
    private float maxDistance;
    [SerializeField]
    RaycastHit hit;
    [HideInInspector]
    public float TargetHeight;
    private float MinimumDistance = 3f;




    // Update is called once per frame
    void Update()
    {
        
        Ray Pos = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(Pos, out hit, Mathf.Infinity))
        {
            if(hit.collider.tag == "Environment")
            {
                float DistanceToGround = hit.distance;
                if (DistanceToGround < maxDistance)
                {
                    float Distance = transform.position.y + maxDistance;
                    TargetHeight = Distance;
                    //transform.position += new Vector3(0, 0.2f, 0);
                }
            }
        }
    }
}
