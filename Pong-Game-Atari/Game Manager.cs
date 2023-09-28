using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // adicona comandos de interface de usuario

public class GameManager : MonoBehaviour
{
    public int pontuacaoDoJogador1;

    public int pontuacaoDoJogador2;

    public Text textoDePontuacao;

    public AudioSource somDoGol;

    void Start()
    {
        pontuacaoDoJogador1 = 0; //zera a pontuação dos jogadores sempre  que a partida inicia
        pontuacaoDoJogador2 = 0;
        textoDePontuacao.text = pontuacaoDoJogador1 + " x " + pontuacaoDoJogador2;
    }

    void Update()
    {
        
    }
    public void AumentarPontuacaoDoJogador1()
    {
        pontuacaoDoJogador1 += 1;
        AtualizarTextoDePontuacao();
    }
    public void AumentarPontuacaoDoJogador2()
    {
       pontuacaoDoJogador2 += 1;
       AtualizarTextoDePontuacao();
    }
    public void AtualizarTextoDePontuacao()
    {
        textoDePontuacao.text = pontuacaoDoJogador1 + " x " + pontuacaoDoJogador2;
        somDoGol.Play();    
    }

}
