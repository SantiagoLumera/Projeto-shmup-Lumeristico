using UnityEngine;

public class VidaAsteroide : MonoBehaviour
{
    public int vida = 250;


    private void OnCollisionEnter(Collision objetoQueBateu)
    {
        if (objetoQueBateu.gameObject.CompareTag("Tiro"))
        {
            TiroNormal scriptDaBala = objetoQueBateu.gameObject.GetComponent<TiroNormal>();
            TomarDano(scriptDaBala.danoAtual);
            Destroy(objetoQueBateu.gameObject);
        }
    }

    public void TomarDano(int dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

}
