using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgroRange : MonoBehaviour
{
	[HideInInspector]
	public string Tag = "Player";
	public float _AgroRange =10f;
	private bool PlayerFound = false;

	void Start()
	{
		InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}

	//check if player is in range
	void UpdateTarget()
	{
		GameObject player = GameObject.FindGameObjectWithTag(Tag);
			float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
			if (distanceToPlayer <= _AgroRange)
			{
				PlayerFound = true;
				GetComponent<StateManager>().ChangeBehavoir("Found");
			}
			else if(distanceToPlayer >= _AgroRange && PlayerFound == true)
        {
			GetComponent<StateManager>().ChangeBehavoir("OutOfRange");
		}

	}


}

