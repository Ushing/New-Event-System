using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundROtation : MonoBehaviour
{
    private float speed = 100f; 
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        transform.Rotate(Vector3.up * speed * Time.fixedDeltaTime);
    }
}
