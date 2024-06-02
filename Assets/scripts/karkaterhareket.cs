using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class karkaterhareket : MonoBehaviour
{
    public float yatayHareket;
    public int hareketHýzý;
    public int zýplamaHýzý;
    public int zýplamaHakký;

    
    Rigidbody2D rb;

    public bool karakteryerde = true;
    public bool faceright = true;

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        zýplamaHakký = 2;
    }
    void Update()
    {
     //  yatayHareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayHareket * hareketHýzý * 100 * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && (karakteryerde == true || zýplamaHakký > 0))
        {
            rb.velocity = Vector2.up * zýplamaHýzý * 100 * Time.deltaTime;
            karakteryerde = false;
            zýplamaHakký -= 1;
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
            zýplamaHakký = 2;
        }
        

    }
    void turn()
    {
        faceright = !faceright;
        Vector2 yenýscale = transform.localScale;
        yenýscale.x *= -1;
        transform.localScale = yenýscale;
    }
    public void Sol()
    {
        yatayHareket = -1;
    }
    public void Sað()
    {
        yatayHareket = 1;
    }
    public void Dur()
    {
        yatayHareket = 0;
    }
    


}
 