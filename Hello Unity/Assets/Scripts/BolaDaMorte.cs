using UnityEngine;

/// <summary>
/// Controla o comportamento das bolinhas da morte.
/// </summary>
public class BolaDaMorte : MonoBehaviour
{
    [SerializeField] private float velocidade = 1f;
    [SerializeField] private GameObject textLose;
    [SerializeField] private GameObject botaoReiniciar;
    [SerializeField] private Transform jogador;

    /// <summary>
    /// A cada frame, orientar para onde o jogador está e então movimentar-se até ele.
    /// Usa-se deltaTime para que o jogo calcule a velocidade do objeto 
    /// em função do tempo de cálculo de cada frame. Assim evitando que
    /// o objeto dê a impressão de que está "lag" em alguns computadores ou 
    /// muito rápidos em computadores com capacidade de cálculo maior.
    /// </summary>
    private void Update()
    {
        Vector3 relativo = jogador.position - this.transform.position;
        this.transform.Translate(relativo * velocidade * Time.deltaTime);
    }

    /// <summary>
    /// Quando este objeto colidir com o jogador.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ControleJogador>().Desativar();
            textLose.SetActive(true);
            botaoReiniciar.SetActive(true);
        }
    }
}
