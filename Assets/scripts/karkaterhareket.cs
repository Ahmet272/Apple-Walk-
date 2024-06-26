using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class karkaterhareket : MonoBehaviour
{
    public float yatayHareket;
    public int hareketHızı;
    public int zıplamaHızı;
    public int zıplamaHakkı;

    
    Rigidbody2D rb;

    public bool karakteryerde = true;
    public bool faceright = true;

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        zıplamaHakkı = 2;
    }
    void Update()
    {
     //  yatayHareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayHareket * hareketHızı * 100 * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && (karakteryerde == true || zıplamaHakkı > 0))
        {
            rb.velocity = Vector2.up * zıplamaHızı * 100 * Time.deltaTime;
            karakteryerde = false;
            zıplamaHakkı -= 1;
        }
        if(yatayHareket > 0 && faceright == false)
        {
            turn();
        }
        if (yatayHareket < 0 && faceright == true)
        {
            turn();
        }
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "zemin")
        {
            karakteryerde = true;
            zıplamaHakkı = 2;
        }
        

    }
    void turn()
    {
        faceright = !faceright;
        Vector2 yenıscale = transform.localScale;
        yenıscale.x *= -1;
        transform.localScale = yenıscale;
    }
    public void Sol()
    {
        yatayHareket = -1;
    }
    public void Sağ()
    {
        yatayHareket = 1;
    }
    public void Dur()
    {
        yatayHareket = 0;
    }
    


}
 