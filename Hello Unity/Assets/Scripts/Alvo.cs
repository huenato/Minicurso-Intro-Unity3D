using UnityEngine;

/// <summary>
/// Classe para adicionar comportamento de Alvo a certo objeto do jogo.
/// </summary>
public class Alvo : MonoBehaviour
{
    private StageManager _stageManager;
    private ScoreManager _scoreManager;
    [SerializeField] private int _valePontos;

    private void Start()
    {
        Inicializar();
    }

    private void Inicializar()
    {
        if (_stageManager == null)
        {
            _stageManager = FindObjectOfType<StageManager>();
        }

        if (_scoreManager == null)
        {
            _scoreManager = FindObjectOfType<ScoreManager>();
        }

        _stageManager.AdicionarNovoAlvo();
    }

    /// <summary>
    /// Método acionado quando o alvo colidir com algo que possa colidir com ele.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        _stageManager.AlvoPego();
        _scoreManager.AlvoPego(_valePontos);
        this.gameObject.SetActive(false);
    }

    /// <summary>
    /// A cada frame, rotacionar este objeto.
    /// </summary>
    private void Update()
    {
        this.gameObject.transform.Rotate(new Vector3(1, 3, 7));
    }
}
