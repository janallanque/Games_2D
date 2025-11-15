using UnityEngine;

public class ControleGato : MonoBehaviour
{
    // Variável para controlar a força do pulo. Você pode ajustar este valor no Inspector da Unity.
    public float forcaPulo = 10f;

    // Referência para o componente Rigidbody2D do gato.
    private Rigidbody2D rb;

    // Variáveis para checar se o personagem está no chão.
    public Transform peDoGato; // Um objeto que ficará nos pés do gato para detectar o chão.
    public float raioDeteccao = 0.2f;
    public LayerMask oQueEhChao; // Define o que será considerado como chão.
    private bool estaNoChao;

    // Start é chamado antes do primeiro frame.
    void Start()
    {
        // Pega o componente Rigidbody2D que está no mesmo GameObject deste script.
        rb = GetComponent<Rigidbody2D>();
    }

    // Update é chamado a cada frame.
    void Update()
    {
        // Checa se o botão "Jump" (Espaço por padrão) foi pressionado E se o gato está no chão.
        if (Input.GetButtonDown("Jump") && estaNoChao)
        {
            // Adiciona uma força vertical para fazer o gato pular.
            // Usamos ForceMode2D.Impulse para uma força instantânea.
            rb.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
        }
    }

    // FixedUpdate é chamado em um intervalo fixo e é ideal para cálculos de física.
    void FixedUpdate()
    {
        // Cria um círculo invisível nos pés do gato para detectar se está tocando o chão.
        estaNoChao = Physics2D.OverlapCircle(peDoGato.position, raioDeteccao, oQueEhChao);
    }
}