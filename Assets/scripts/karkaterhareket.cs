using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class karkaterhareket : MonoBehaviour
{
    public float yatayHareket;
    public int hareketH�z�;
    public int z�plamaH�z�;
    public int z�plamaHakk�;

    
    Rigidbody2D rb;

    public bool karakteryerde = true;
    public bool faceright = true;

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        z�plamaHakk� = 2;
    }
    void Update()
    {
     //  yatayHareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayHareket * hareketH�z� * 100 * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && (karakteryerde == true || z�plamaHakk� > 0))
        {
            rb.velocity = Vector2.up * z�plamaH�z� * 100 * Time.deltaTime;
            karakteryerde = false;
            z�plamaHakk� -= 1;
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
            z�plamaHakk� = 2;
        }
        

    }
    void turn()
    {
        faceright = !faceright;
        Vector2 yen�scale = transform.localScale;
        yen�scale.x *= -1;
        transform.localScale = yen�scale;
    }
    public void Sol()
    {
        yatayHareket = -1;
    }
    public void Sa�()
    {
        yatayHareket = 1;
    }
    public void Dur()
    {
        yatayHareket = 0;
    }
    


}
 