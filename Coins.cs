using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //transform.Rotate(0f, 60 * Time.deltaTime, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerManager.NumberOfCoins += 1;
    
            Destroy(gameObject);
        }
    }
}
