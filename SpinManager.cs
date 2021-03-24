using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinManager : MonoBehaviour
{
    public SpenRotation _spinner;
   // public Text Countvalu;

    
    public GameObject panal;

    //public GameObject fish_1;
    //public GameObject fish_2;
    //public GameObject fish_3;
    public GameObject fish_4;
    //public GameObject fish_5;
    //public GameObject fish_6;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!_spinner.isStoped)
            return;
      // Countvalu.text = collision.gameObject.name;
        panal.SetActive(true);
        fish_4.SetActive(true);
    }
}
