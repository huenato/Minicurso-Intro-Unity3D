using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe que atualiza o texto de pontos.
/// </summary>
public class ScoreUi : MonoBehaviour
{
    [SerializeField] private Text _textoScore;
    [SerializeField] private ScoreManager _scoreManager;

    /// <summary>
    /// A cada frame, atualizamos o texto de Pontos do jogador.
    /// </summary>
    private void Update()
    {
        _textoScore.text = "Pontos: " + _scoreManager.Pontos;
    }
}
