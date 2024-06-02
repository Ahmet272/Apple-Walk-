using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeviyelerButton : MonoBehaviour
{
    public TMP_Text highscoreText;


     void Start()
    {
        highscoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }
    public void seviyeler()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        scoreGenerator.yýldýzpuaný_int = 0;
    }
}
