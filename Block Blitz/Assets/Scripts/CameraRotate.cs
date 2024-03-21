using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float speed = 10f;
    private Transform _rotator;
    
    void Start()
    {
        _rotator = GetComponent<Transform>();
    }

    void Update()
    {
        _rotator.Rotate(0, speed * Time.deltaTime, 0);
    }
}
