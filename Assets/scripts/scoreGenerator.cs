using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreGenerator : MonoBehaviour
{
    public Text y�ld�zpuan�;
    public static int y�ld�zpuan�_int =0;


   

    private void Update()
    {
        y�ld�zpuan�.text = y�ld�zpuan�_int.ToString();

        if (y�ld�zpuan�_int > PlayerPrefs.GetInt("highScore")) {
            PlayerPrefs.SetInt("highScore", y�ld�zpuan�_int);
        }
    }
}

