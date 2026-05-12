using UnityEngine;

public class TiroNormal : MonoBehaviour
{
    public float velocidade = 10f;
    public float tempoParaSumir = 5f;

    public int danoAtual = 25;



    private void Start()
    {
        Destroy(gameObject,tempoParaSumir);
    }
    void Update()
    {
        transform.position += transform.forward * velocidade * Time.deltaTime;
    }




}
