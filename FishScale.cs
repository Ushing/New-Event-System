using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FishScale : MonoBehaviour
{
    public Transform newImage1;
    public float newImage1Anim;
    void Start()
    {
        newImage1
            .DOScale(1.5f, newImage1Anim);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
