using UnityEngine;

public class VidaAsteroide : MonoBehaviour
{
    public int vida = 250;
    public TiroNormal tiroNormal;

    private void OnCollisionEnter(Collision objetoQueBateu)
    {
        if (objetoQueBateu.gameObject.CompareTag("Tiro"))
        {
            TomarDano(tiroNormal.danoAtual);
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
