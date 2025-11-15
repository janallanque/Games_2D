using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovimentoPersonagem : MonoBehaviour
{
    [Header("Referências do Jogo")]
    // Arraste o GameObject do seu personagem (que tem a cabeça amarela) aqui.
    public Transform personagem;

    // Crie uma lista com todas as casas roxas, na ordem em que devem ser percorridas.
    public List<Transform> caminhoDeCasas;

    [Header("Configurações do Pulo")]
    // Velocidade com que o personagem se move de uma casa para outra.
    public float velocidadeDoPulo = 4.0f;

    // O quão alto o personagem vai pular.
    public float alturaDoPulo = 1.5f;

    // Um ajuste para garantir que o personagem pise EM CIMA da casa, e não no meio dela.
    public float ajusteAltura = 0.5f;

    void Start()
    {
        // Verifica se o caminho foi configurado antes de começar.
        if (personagem != null && caminhoDeCasas.Count > 0)
        {
            // Inicia a rotina que move o personagem pelo caminho.
            StartCoroutine(SeguirOCaminho());
        }
        else
        {
            Debug.LogError("Configure as referências 'Personagem' e 'CaminhoDeCasas' no Inspector!");
        }
    }

    // Corrotina principal que guia o personagem pela jornada.
    IEnumerator SeguirOCaminho()
    {
        // 1. Posiciona o personagem no início do caminho.
        Vector3 primeiraPosicao = caminhoDeCasas[0].position + new Vector3(0, ajusteAltura, 0);
        personagem.position = primeiraPosicao;

        // Espera 1 segundo antes de começar a pular.
        yield return new WaitForSeconds(1f);

        // 2. Loop 'for' para percorrer o caminho de casa em casa.
        // O loop vai até a penúltima casa, pois sempre olhamos para a "próxima".
        for (int i = 0; i < caminhoDeCasas.Count - 1; i++)
        {
            // Posição inicial do pulo (a casa atual).
            Vector3 pontoInicial = caminhoDeCasas[i].position + new Vector3(0, ajusteAltura, 0);

            // Posição final do pulo (a próxima casa).
            Vector3 pontoFinal = caminhoDeCasas[i + 1].position + new Vector3(0, ajusteAltura, 0);

            // Chama a outra corrotina para executar o pulo e espera ela terminar.
            yield return StartCoroutine(ExecutarPulo(pontoInicial, pontoFinal));
        }

        Debug.Log("Jornada concluída! O personagem chegou ao final do caminho.");
    }

    // Corrotina que calcula e anima um único pulo.
    IEnumerator ExecutarPulo(Vector3 inicio, Vector3 fim)
    {
        float tempoDecorrido = 0f;
        float duracao = Vector3.Distance(inicio, fim) / velocidadeDoPulo;

        while (tempoDecorrido < duracao)
        {
            // Calcula o progresso do pulo (de 0 a 1).
            float progresso = tempoDecorrido / duracao;

            // Move o personagem linearmente do início ao fim.
            Vector3 posicaoLinear = Vector3.Lerp(inicio, fim, progresso);

            // Adiciona uma curva (parábola) para simular o arco do pulo.
            float alturaArco = alturaDoPulo * 4 * (progresso - progresso * progresso);

            // Combina o movimento linear com o arco do pulo.
            personagem.position = new Vector3(posicaoLinear.x, posicaoLinear.y + alturaArco, posicaoLinear.z);

            tempoDecorrido += Time.deltaTime;
            yield return null; // Espera o próximo frame.
        }

        // Garante que o personagem termine exatamente na posição final.
        personagem.position = fim;
    }
}