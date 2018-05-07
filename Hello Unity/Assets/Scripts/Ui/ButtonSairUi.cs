using UnityEngine;

/// <summary>
/// Controla as funções do botão sair.
/// </summary>
public class ButtonSairUi : MonoBehaviour
{
    public void SairDoJogo()
    {
        Debug.Log("Sair do jogo chamado");
        Application.Quit();
    }
}
