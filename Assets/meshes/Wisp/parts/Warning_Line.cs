using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning_Line : MonoBehaviour
{
    public LineRenderer line;
    public Transform pos1;
    private TrackPlayer PlayerLocation;
    void Start()
    {
        PlayerLocation = GetComponentInChildren<TrackPlayer>();
        line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        pos1 = PlayerLocation.PlayerLocation;
        line.SetPosition(0, gameObject.transform.position);
        line.SetPosition(1, pos1.transform.position);
    }
}
