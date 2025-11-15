using UnityEngine;

public class Operadores : MonoBehaviour
{
    void Start()
    {
        //Operadores aritmeticos

        int a = 10;
        int b = 3;

        Debug.Log("Soma: " + (a + b));
        Debug.Log("Subtração: " + (a - b));
        Debug.Log("Multiplicação: " + (a * b));
        Debug.Log("Divisão: " + ((float)a / b).ToString("F2"));

        //Operadores de comparacao

        Debug.Log("Igualdade: " + (a == b));
        Debug.Log("Diferença: " + (a != b));
        Debug.Log("Maior que: " + (a > b));
        Debug.Log("Menor que: " + (a < b));
        Debug.Log("Maior ou igual a: " + (a >= b));
        Debug.Log("Menor ou igual a: " + (a <= b));

        //Operadores logicos
        bool condicao1 = true;
        bool condicao2 = false;
        Debug.Log("AND lógico: " + (condicao1 && condicao2));
        Debug.Log("OR lógico: " + (condicao1 || condicao2));

        bool resultado1 = (a > b) && (a > 5);
        Debug.Log("Resultado 1 (a > b AND a > 5): " + resultado1);

        bool resultado2 = (a == 100) || (a > 5);
        Debug.Log(resultado2);
    }
}
