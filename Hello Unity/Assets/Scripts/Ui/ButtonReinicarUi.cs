using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controla as funções do botão iniciar.
/// </summary>
public class ButtonReinicarUi : MonoBehaviour
{
    /// <summary>
    /// Método para reiniciar a cena.
    /// </summary>
	public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
