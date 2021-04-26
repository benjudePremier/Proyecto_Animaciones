using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float Velocidad;
    private float Horizontal;
    // Ejecuta al inicio al momento de darle Play!
    void Start()
    {
        Velocidad = 4f;
        
    }

    // Ejecuta a medida  que vamos juagando Frame  x Frame
    void Update()
    {

        transform.Translate(Velocidad * Time.deltaTime, 0, 0);

        Horizontal = Input.GetAxis("Horizontal") * Velocidad;
        transform.Translate(Horizontal * Time.deltaTime, 0, 0);

    }
}
