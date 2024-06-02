using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeScript : MonoBehaviour
{
  public void backHome()
    {
        SceneManager.LoadScene(0);
    }

}
