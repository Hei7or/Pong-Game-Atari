using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool golDoJogador1;

    void OnTriggerEnter2D(Collider2D other) //identifica colisões em um trigger
    {
        if(golDoJogador1 == true) // se o jogador 1 fizer gol
        {
            FindAnyObjectByType<GameManager>().AumentarPontuacaoDoJogador2(); //procura o codigo de aumentar pontuação e gera a pontuação ao jogador 2

            other.gameObject.transform.position = Vector2.zero; //vai na variavel other que é o local que colidiu com o trigger e volta ela para posicão 0
        }
        else  // se o jogaor 2 fizer gol
        {
            FindAnyObjectByType<GameManager>().AumentarPontuacaoDoJogador1();

            other.gameObject.transform.position = Vector2.zero; //vai na variavel other que é o local que colidiu com o trigger e volta ela para posicão 0
        }
    }
}