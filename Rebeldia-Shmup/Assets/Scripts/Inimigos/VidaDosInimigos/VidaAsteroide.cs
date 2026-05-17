using UnityEngine;
using UnityEngine.Rendering.Universal;

//ISSO TA MAIS PRA CONTROLE DE TUDO NO ASTEROIDE DO QUE APENAS SO PARA VIDA DELE

public class VidaAsteroide : MonoBehaviour
{
    public int vida = 250;
    public ControleVidaPlayer player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tiro"))
        {
            TiroNormal scriptDaBala = other.gameObject.GetComponent<TiroNormal>();
            TomarDano(scriptDaBala.danoAtual);
            Destroy(other.gameObject);
        }


        if (other.gameObject.CompareTag("Player"))
        {
            player.ReceberDano(40);
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("DanoConstante"))
        {
            SuperLaser scriptDoLaser = other.gameObject.GetComponent<SuperLaser>();
            if (scriptDoLaser.laserDanoAtivo == true)
            {
                TomarDano(scriptDoLaser.danoDoLaser);
                scriptDoLaser.laserDanoAtivo = false;
                scriptDoLaser.tempoDoDano = 1f;
            }
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
