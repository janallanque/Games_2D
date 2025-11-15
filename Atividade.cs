using UnityEngine;

public class Atividade : MonoBehaviour
{
    string nomePersonagem = "Shena";
    int vidaPersonagem = 150;
    int danoRecebido = 40;
    int vidaRestante;
    int nivelPersonagem = 5;
    int experienciaPersonagem = 1200;
    int experienciaParaProximoNivel = 1500;
    int moedasOuro = 300;
    int moedasPorNivel = 200;
    int experienciaPorNivel = 300;

    void Start()
    {
        //Operadores Aritméticos
        Debug.Log("Personagem: " + nomePersonagem);
        Debug.Log("Vida Inicial: " + vidaPersonagem);
        Debug.Log("Dano Recebido: " + danoRecebido);
        Debug.Log("Vida Restante: " + (vidaPersonagem - danoRecebido));
        Debug.Log("Nível atual: " + nivelPersonagem);
        Debug.Log("Moedas para subir de nível: " + (moedasOuro + moedasPorNivel));
        Debug.Log("Moedas de Ouro: " + moedasOuro);
        Debug.Log("Experiência por nível: " + ((float)experienciaPersonagem/nivelPersonagem).ToString("F2"));
        Debug.Log("Experiência necessária para o próximo nível: " + ((float)experienciaParaProximoNivel / nivelPersonagem).ToString("F2"));
        Debug.Log("Experiência acumulada: " +  (nivelPersonagem * experienciaPorNivel));

        //Ação do Personagem

        bool ganhouVidas = true;
        bool ganhouMoedas = true;
        bool perdeuVidas = false;
        bool perdeuMoedas = false;

        //Operadores de Comparação
        Debug.Log("Para subir de nível então ganhou vida e moedas: " + (ganhouVidas && ganhouMoedas));
        Debug.Log("Conquistou para ganhar experiência: " + (ganhouVidas || ganhouMoedas));
        Debug.Log("Perdeu vida e moedas: " + (perdeuVidas && perdeuMoedas));
        Debug.Log("Perdeu vida ou moedas: " + (perdeuVidas || perdeuMoedas));

        //Operadores Logicos
        Debug.Log("Vida Restante suficiente: " + (vidaPersonagem >= danoRecebido));
        Debug.Log("Moedas suficientes para comprar item: " + (moedasOuro >= 500));
        Debug.Log("Nível máximo atingido: " + (nivelPersonagem == 10));
        Debug.Log("Personagem em perigo: " + (vidaRestante <= 50));
        Debug.Log("Personagem saudável: " + (vidaRestante >= 100));

    }

}
