using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public float fuerzasalto; // para el personaje salto
    public LayerMask suelo; // es la capa del terreno.
    public Transform pie;   // es el pie del jugador.
    public float radiopie; // rango de deteccion del suelo.
    public bool Suelo; // Dertermina caundo tooca el suelo

    private Rigidbody2D rigitbody;
    // Ejecuta al inicio al momento de darle Play!
    void Start()
    {
        fuerzasalto = 7f;
        radiopie = 1f;
        Suelo = false;
        rigitbody = GetComponent<Rigidbody2D>();

    }

   // Ejecuta a medida que vamos jugando Frame x Frame
    void Update()
    {

        Suelo = Physics2D.OverlapCircle(pie.position, radiopie, suelo);
        if (Input.GetKey("w") && Suelo == true)
        {
            rigitbody.velocity = new Vector2(rigitbody.velocity.x, fuerzasalto);
        }
    }
}