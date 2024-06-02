using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScrıpt : MonoBehaviour
{
  public void restartClick()
    {
        SceneManager.LoadScene(1);
        scoreGenerator.yıldızpuanı_int = 0;
    }

}
