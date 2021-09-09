using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaPla : MonoBehaviour
{
    // Start is called before the first frame update
    int velocidad = 7;
    Rigidbody2D rb;
    Animator animacion;
    public int fuersaSalto = 1400;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animacion.SetInteger("Estado", 0);
        rb.velocity = new Vector2(velocidad, rb.velocity.y);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animacion.SetInteger("Estado", 1);
            rb.AddForce(Vector2.up * fuersaSalto);

        }
        
    }
    void OnCollisionEnter2D(Collision2D objet)
    {

        if (objet.gameObject.tag == "zombi")
        { 
            Debug.Log("Zombie");
            velocidad = 0;
            //  animacion.SetInteger("Estado", 2);
            Destroy(this.gameObject);
        }
    }
}
//Piso