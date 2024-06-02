using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YONETICIPAUSE : MonoBehaviour
{
    public bool oyundurdumu = false;
    public GameObject PauseMenuScreen;
    public void oyunudurdur()
    {
        PauseMenuScreen.SetActive(true);
        Time.timeScale = 0f;
       /* if (oyundurdumu == false)
        {
            Time.timeScale = 0f;
            oyundurdumu = true;
        }
       else
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        } */
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PauseMenuScreen.SetActive(false);
    }
    public void GoToHome()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(0);
    }

}
