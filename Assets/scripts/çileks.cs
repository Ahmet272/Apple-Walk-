using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
  

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "karakter")
        {
            scoreGenerator.y�ld�zpuan�_int += 1;
            Destroy(this.gameObject);
        }
        if (temas.gameObject.tag == "ananasKarakter")
        {
            scoreGenerator.y�ld�zpuan�_int += 1;
            Destroy(this.gameObject);
        }
        if (temas.gameObject.tag == "drill")
        {
            scoreGenerator.y�ld�zpuan�_int += 1;
            Destroy(this.gameObject);
        }
    }
   

}
