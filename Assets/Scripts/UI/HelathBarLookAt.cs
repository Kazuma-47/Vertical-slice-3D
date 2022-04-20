using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelathBarLookAt : MonoBehaviour
{
    Transform camera;
    [HideInInspector] public bool Main = true;
    public GameObject Canvas;
    private void Start()
    {
        camera = Camera.main.transform;
    }
    void Update()
    {
            camera = Camera.main.transform;
            Canvas.transform.LookAt(camera);
        
    }
}
