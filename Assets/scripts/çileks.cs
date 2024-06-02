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
            scoreGenerator.yýldýzpuaný_int += 1;
            Destroy(this.gameObject);
        }
        if (temas.gameObject.tag == "ananasKarakter")
        {
            scoreGenerator.yýldýzpuaný_int += 1;
            Destroy(this.gameObject);
        }
        if (temas.gameObject.tag == "drill")
        {
            scoreGenerator.yýldýzpuaný_int += 1;
            Destroy(this.gameObject);
        }
    }
   

}
