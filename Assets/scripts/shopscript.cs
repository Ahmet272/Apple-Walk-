using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SHOPMANAGERscript : MonoBehaviour
{
    public void shopbackbutton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        scoreGenerator.yýldýzpuaný_int = 0;

    }
    public void ananasbutton()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
        scoreGenerator.yýldýzpuaný_int = 0;

    }
    public void applebutton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        scoreGenerator.yýldýzpuaný_int = 0;

    }
    public void drillbutton()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1;
        scoreGenerator.yýldýzpuaný_int = 0;

    }
}
