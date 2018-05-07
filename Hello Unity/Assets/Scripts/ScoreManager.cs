using UnityEngine;

/// <summary>
/// Classe que gerencia o score do jogo.
/// </summary>
public class ScoreManager : MonoBehaviour
{
    [HideInInspector] public int Pontos = 0;

    /// <summary>
    /// Como o Unity executa o método Start() a cada
    /// novo carregamento da cena, aqui iniciamos 
    /// o número de pontos em 0.
    /// </summary>
    private void Start()
    {
        Pontos = 0;
    }

    /// <summary>
    /// Adiciona X número de pontos ao contador de pontos.
    /// Este método geralmente é chamado pelos alvos.
    /// </summary>
    /// <param name="pontos">Quantidade de pontos a serem adicionados.</param>
    public void AlvoPego(int pontos)
    {
        this.Pontos += pontos;
    }
}
