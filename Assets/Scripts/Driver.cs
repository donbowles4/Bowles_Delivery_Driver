using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float fltSteerSpeed = 1f;
    float fltMoveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, fltSteerSpeed);
        transform.Translate(0, fltMoveSpeed, 0);
    }
}
