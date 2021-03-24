using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpenRotation : MonoBehaviour
{
    public float reducer;
    public float multiplier = 1;
    bool round1 = false;
    public bool isStoped = false;

    private void Start()
    {
        reducer = Random.Range(0.01f, 0.5f);
    }
    public void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Reset();
        }
        
        if (multiplier > 0)
        {
            transform.Rotate(Vector3.forward, 1 * multiplier);
        }
        else
        {
            isStoped = true;
        }
        if(multiplier < 20 && ! round1)
        {
            multiplier += 0.1f;
        }
        else
        {
            round1 = true;
        }
        if(round1 && multiplier >0)
        {
            multiplier -= reducer;
        }
    }
    void Reset()
    {
        multiplier = 1;
        reducer = Random.Range(0.01f, 0.5f);
        round1 = false;
        isStoped = false;
    }

}
