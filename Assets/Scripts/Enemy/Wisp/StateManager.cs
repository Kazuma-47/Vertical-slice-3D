using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{ //different kinds of states
   [HideInInspector]
    public enum State
    {
        Inactive,
        FoundPlayer,
        OutOfRange
    }
    public State state;


    private void Update()
    {
        switch (state)
        {
            case State.Inactive:
                GetComponentInChildren<Wisp_Shoot>().enabled = false;
                GetComponentInChildren<TrackPlayer>().enabled = false;
                GetComponent<Movement>().enabled = false;
                    break;

            case State.FoundPlayer:
                GetComponentInChildren<Wisp_Shoot>().enabled = true;
                GetComponentInChildren<TrackPlayer>().enabled = true;
                GetComponent<Movement>().enabled = true;
                break;

            case State.OutOfRange:
                GetComponentInChildren<Wisp_Shoot>().enabled = false;
                GetComponentInChildren<TrackPlayer>().enabled = false;
                //laat enemy naar player bewegen tot hij in range is
                break;
        }
    }

    public void ChangeBehavoir(string Type)
    {
        switch (Type)
        {
            case "Found":
                state = State.FoundPlayer;
                break;
            case "OutOfRange":
                state = State.OutOfRange;
                break;
        }
    }
}
