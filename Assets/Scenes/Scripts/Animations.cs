using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator anime;
        
    void Start()
    {
        anime = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        anime.SetFloat("Velocidad", this.GetComponent<Mover>().Velocidad);
    }
}
