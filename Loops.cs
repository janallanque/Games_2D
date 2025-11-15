using UnityEngine;
using System.Collections.Generic;

public class Loops : MonoBehaviour
{
    void Start()
    {
        // For
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("For: " + i);
        }

        Debug.Log("--------------------");

        // While
        int j = 0;
        while (j < 5)
        {
            Debug.Log("While: " + j);
            j++;
        }

        Debug.Log("--------------------");

        // Do While
        int k = 0;
        do
        {
            Debug.Log("Do While: " + k);
            k++;
        } while (k < 5);

        Debug.Log("--------------------");

        // Foreach com Array
        int[] numeros = { 1, 2, 3, 4, 5 };
        foreach (int numero in numeros)
        {
            Debug.Log("Foreach (Array): " + numero);
        }

        Debug.Log("--------------------");

        // Foreach com Lista
        List<string> nomes = new List<string> { "Jonathan", "Clay", "Janei" };
        foreach (string nome in nomes)
        {
            Debug.Log("Foreach (List): " + nome);
        }
    }
}