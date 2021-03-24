using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManu : MonoBehaviour
{
    public void Click_Manu(string Scene_name)
    {
        SceneManager.LoadScene(Scene_name);
    }
}
