using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScrıpt : MonoBehaviour
{
    public GameObject panel;
    public GameObject karakter;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "karakter" && scoreGenerator.yıldızpuanı_int == 1)
        {
            panel.SetActive(true);
            karakter.SetActive(false);
        }
    }
}
