using UnityEngine;

public class ControleVidaPlayer : MonoBehaviour
{
    public int vidaMaxima = 100;
    public int vidaAtual = 100;


    public void ReceberDano(int dano)
    {
        vidaAtual -= dano;
        if (vidaAtual <= 0)
        {
            Morrer();
        }
    }

    public void Curar(int cura)
    {
        vidaAtual += cura;
        if (vidaAtual > vidaMaxima)
        {
            vidaAtual = vidaMaxima;
        }
    }

    public void Morrer()
    {
        // Aqui você pode adicionar efeitos de morte, animações, ou reiniciar o jogo
        Debug.Log("O jogador morreu!");
        // Por exemplo, para reiniciar a cena:
        // UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }





}
