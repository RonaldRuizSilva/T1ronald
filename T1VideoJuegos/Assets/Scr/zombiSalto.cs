using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiSalto : MonoBehaviour
{
    Rigidbody2D rb;
    public int fuerza = 100;
    bool Saltar = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Saltar == false)
        {
            Saltar = true;
            rb.AddForce(Vector2.up * fuerza);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            Saltar = false;
        }
       
    }
}
