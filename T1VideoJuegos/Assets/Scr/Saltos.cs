using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltos : MonoBehaviour
{
    Rigidbody2D rb;
    public int fuerza = 1600;
    bool SaltosFuer = true;
    SpriteRenderer direcionPersonaje;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direcionPersonaje = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (SaltosFuer == true)
        {
            SaltosFuer = false;
            rb.AddForce(Vector2.up * fuerza);
 
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            SaltosFuer = true;
            direcionPersonaje.flipX = !direcionPersonaje.flipX;
        }
    }
}
