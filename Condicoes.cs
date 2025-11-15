using UnityEngine;
public class Condicoes : MonoBehaviour
{
    void Start()
    {
        //If-Else
        int numero = 10;
        if (numero > 0)
        {
            Debug.Log("O número é maior que 0");
        }
        else
        {
            Debug.Log("O número é menor que 0");
        }

        bool haInimigos = false;

        if (haInimigos)
        {
            Debug.Log("Cuidado!!!");
        }
        else
        {
            Debug.Log("Pode sair Player!");
        }

        //If__Else If__Else
        int temperatura = 30;
        if (temperatura > 30)
        {
            Debug.Log("Está muito quente!");
        }
        else if (temperatura < 10)
        {
            Debug.Log("Está muito frio!");
        }
        else
        {
            Debug.Log("Temperatura esta adequada.");
        }

        //Operador Ternário
        int numerodeInimigos = 5;
        string resultado = (numerodeInimigos > 10) ? "Cuidado, há inimigos!" : "Está seguro!";
        Debug.Log(resultado);

        //Switch Case
        int level = 1;
        switch (level)
        {
            case 1:
                Debug.Log("Você está no Level 1");
                break;
            case 2:
                Debug.Log("Level Intermediário");
                break;
            case 3:
                Debug.Log("Level Avançado");
                break;
            default:
                Debug.Log("Nível desconhecido");
                break;
        }

    }
}