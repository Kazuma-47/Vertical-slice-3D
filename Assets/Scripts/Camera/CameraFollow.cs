using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float offset;
    private Vector3 playerPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        transform.position = new Vector3 (playerPos.x, playerPos.y, playerPos.z + offset);
    }
}
