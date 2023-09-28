using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidadeDaBola;

    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;

    public Rigidbody2D oRigidbody2d;

    public AudioSource somDaBola;
   
    void Start()
    {
        MoverBola();
    }

   
    void Update()
    {
        
    }

    private void MoverBola()
    {
        oRigidbody2d.velocity = new Vector2(velocidadeDaBola, velocidadeDaBola);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)  //vai gerar um som quando algum objeto colidir com a bola
    {
        somDaBola.Play();
        oRigidbody2d.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
    }
}