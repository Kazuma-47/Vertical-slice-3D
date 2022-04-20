using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private GoundCheck _groundCheck;
    private StateManager _stateManager;

    [HideInInspector]
    public float Y_coordinate;
    public string Tag = "Player";
    [SerializeField]
    private float _Range = 10f;
    [SerializeField]
    private GameObject _player;
    private float _playerPosX;
    private float _playerPosZ;
    private float _PosY;

    public float Speed = 3f;


    void Start()
    {
 
        _player = GameObject.FindGameObjectWithTag(Tag);
        _groundCheck = GetComponent<GoundCheck>();
    }
    
    void Update()
    {
        
        _playerPosX = _player.transform.position.x;
        _playerPosZ = _player.transform.position.z;
        _PosY = _groundCheck.TargetHeight;
        RangeToPlayer();
        
    }
    
    private void RangeToPlayer()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, _player.transform.position);
        if (distanceToPlayer > _Range )
        {
            GetComponent<StateManager>().ChangeBehavoir("OutOfRange");
            MoveToPlayer(_playerPosX, _PosY , _playerPosZ);
            
            //cant shoot
        }
        else if(distanceToPlayer < _Range - 3)
        {
            // can shoot
            GetComponent<StateManager>().ChangeBehavoir("Found");
            transform.rotation= Quaternion.identity;
        }
    }
    private void MoveToPlayer(float X , float  Y, float Z)
    {
        Vector3 Target = new Vector3(X, Y, Z);
        //float distance = (Target.transform.position.y - transform.position.y).Magnitude;
        float step = Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Target, step);
    }

}
