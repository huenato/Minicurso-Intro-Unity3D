using UnityEngine;

/// <summary>
/// Classe que gerencia os inputs do jogador.
/// </summary>
public class ControleJogador : MonoBehaviour
{
    [SerializeField] private float _velocidade = 1;
    [SerializeField] private Rigidbody _rigidbody;

    /// <summary>
    /// A cada frame, pegamos os valores do joystick do jogador
    /// e atribuimos ao AddForce() do rigidbody da esfera.
    /// </summary>
    private void Update()
    {
        float hor = Input.GetAxis("Horizontal") * _velocidade;
        float ver = Input.GetAxis("Vertical") * _velocidade;

        _rigidbody.AddForce(new Vector3(hor, 0, ver));
    }

    /// <summary>
    /// Desabilita o componente de controle do jogador (esta classe),
    /// assim o jogador perde o controle do jogo e não mexe a esfera.
    /// </summary>
    public void Desativar()
    {
        _rigidbody.velocity = Vector3.zero;
        this.enabled = false;
    }
}
