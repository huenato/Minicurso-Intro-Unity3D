using UnityEngine;

/// <summary>
/// Gerencia estados do jogo.
/// </summary>
public class StageManager : MonoBehaviour
{
    [SerializeField] private GameObject _textoVenceu;
    [SerializeField] private GameObject _botaoReiniciar;

    private int _numAlvos = 0;
    private int _alvosPegos = 0;

    /// <summary>
    /// Adiciona +1 no contador de alvos na fase.
    /// </summary>
    public void AdicionarNovoAlvo()
    {
        _numAlvos++;
    }

    /// <summary>
    /// Adiciona +1 no contador de alvos pegos durante o jogo.
    /// </summary>
    public void AlvoPego()
    {
        _alvosPegos++;
    }

    /// <summary>
    /// A cada frame, verificamos se o num de alvos pegos é o mesmo
    /// num de alvos que estão na fase.
    /// Se o jogador pegou todos os alvos, mostramos a tela de venceu.
    /// </summary>
    private void Update()
    {
        if (_alvosPegos == _numAlvos)
        {
            if (!_textoVenceu.activeSelf)
            {
                _textoVenceu.SetActive(true);
                _botaoReiniciar.SetActive(true);
                FindObjectOfType<ControleJogador>().Desativar();
                foreach (BolaDaMorte bola in FindObjectsOfType<BolaDaMorte>())
                {
                    bola.gameObject.SetActive(false);
                }
            }
        }
    }
}
