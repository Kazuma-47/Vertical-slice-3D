using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    [HideInInspector] public GameObject Player;
    [HideInInspector] public Transform PlayerLocation;

    void Start()
    {
        Player = GameObject.Find("Player");
     
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLocation = Player.transform;
        transform.LookAt(Player.transform);
    }
}
