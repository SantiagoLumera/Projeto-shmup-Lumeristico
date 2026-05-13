using UnityEngine;

public class PackDeCura : MonoBehaviour
{
    public int cura = 20;
    public ControleVidaPlayer player;

    private void OnTriggerEnter(Collider tiroPraCura)
    {
        if (tiroPraCura.gameObject.CompareTag("Tiro"))
        {
            player.Curar(cura);
            Destroy(tiroPraCura.gameObject);
            Destroy(gameObject);
        }
    }
}
