using UnityEngine;

public class PlayerTeste : MonoBehaviour
{
    void Start()
    {
        string playerName = "Linux";
        int life = 100;
        int damage = 50;

        Debug.Log(
            "Player " + playerName +
            " tem " + life + " de vida, porém tomou " +
            damage + " de dano."
        );
    }
}