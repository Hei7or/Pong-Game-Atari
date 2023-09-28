using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDJ : MonoBehaviour
{
    public float velocidadeDoJogador;

    public bool jogador1;

    public float yMinimo; //valor minimo para o jogador não passar da tela
    public float yMaximo;   
    private void Start()
    {
       
    }
    private void Update()
    {
        if(jogador1 == true) //define qual jogador esta jogando
        {
            MoverJogador1();
        }
        else
        {
            MoverJogador2();
        }
    }

    private void MoverJogador1() //define a telca, velocidade do jogador e mantem a mesma velocidade a diferentes maquinas
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo)); //limita ate onde o jogador pode ir

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime); 
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
    private void MoverJogador2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo)); //limita ate onde o jogador pode ir
            
        if (Input.GetKey(KeyCode.UpArrow)) //define a telca, velocidade do jogador e mantem a mesma velocidade a diferentes maquinas
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }

    }

}


