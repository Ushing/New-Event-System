using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public Transform target;
    public float SmoothSpeed = 0.125f;
    public Vector3 Offset;

    private void LateUpdate()
    {
        transform.position = target.position + Offset;
    }
}
