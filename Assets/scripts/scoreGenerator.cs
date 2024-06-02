using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreGenerator : MonoBehaviour
{
    public Text yýldýzpuaný;
    public static int yýldýzpuaný_int =0;


   

    private void Update()
    {
        yýldýzpuaný.text = yýldýzpuaný_int.ToString();

        if (yýldýzpuaný_int > PlayerPrefs.GetInt("highScore")) {
            PlayerPrefs.SetInt("highScore", yýldýzpuaný_int);
        }
    }
}

