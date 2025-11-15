using UnityEngine;

public class AventuraDoJornadeiro : MonoBehaviour
{
    void Start()
    {
        // Define o número total de passos (casas roxas) na jornada do personagem.
        int totalDePassos = 22;

        Debug.Log("A jornada do nosso herói começa agora!");

        // O loop 'for' faz o personagem avançar passo a passo.
        for (int passoAtual = 1; passoAtual <= totalDePassos; passoAtual++)
        {
            Debug.Log("--- O herói está no passo " + passoAtual + " ---");

            // Condições para cada cenário da jornada.

            // Passos 1 a 4: Agricultura
            if (passoAtual <= 4)
            {
                Debug.Log("Cenário: Planície. O herói aprende sobre agricultura e usa o trator!");
            }
            // Passos 5 a 7: Vila
            else if (passoAtual <= 7)
            {
                Debug.Log("Cenário: Vila. Hora de ajudar a comunidade a construir casas.");
            }
            // Passos 8 a 10: Lago
            else if (passoAtual <= 10)
            {
                Debug.Log("Cenário: Lago. Um desafio de natação para atravessar para o outro lado!");
            }
            // Passos 11 a 13: Floresta
            else if (passoAtual <= 13)
            {
                Debug.Log("Cenário: Floresta. Escalando árvores e explorando a natureza.");
            }
            // Passos 14 a 17: Deserto
            else if (passoAtual <= 17)
            {
                Debug.Log("Cenário: Deserto. Sobrevivendo ao calor e desviando dos cactos!");
            }
            // Passos 18 a 22: Oceano
            else if (passoAtual <= 22)
            {
                Debug.Log("Cenário: Oceano. A aventura termina com uma pescaria em alto mar!");
            }
        }

        Debug.Log("----------------------------------------");
        Debug.Log("FIM DA JORNADA! O herói completou todos os desafios com sucesso!");
    }
}