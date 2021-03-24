using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpinLocation : MonoBehaviour
{
    public void SpinWheelHome(string Scene_name)
    {
        SceneManager.LoadScene(Scene_name);
    }
}
