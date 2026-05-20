using UnityEngine;

public class SpawnAsteroides : MonoBehaviour
{
    public float tempoEntreSpawns = 2f;
    public float velocidadeAsteroides = 3f;

    public GameObject asteroidePrefab;

    //public Transform[] pontosDeSpawn;

    public Vector3 pocicaoSpawn;

    private void Update()
    {


        if (tempoEntreSpawns > 0)
        {
            tempoEntreSpawns -= Time.deltaTime;
        }

        if (tempoEntreSpawns < 0)
        {
            SpawnarAsteroides();
            tempoEntreSpawns = 5;
        }





    }

    void SpawnarAsteroides()
    {
        //int pontoAleatorio = Random.Range(0,pontosDeSpawn.Length);

        pocicaoSpawn = new Vector3(Random.Range(-13, 13), 0, 55);
        

        GameObject novoAsteroide = Instantiate(asteroidePrefab, pocicaoSpawn, Quaternion.identity);
        
        VidaAsteroide scriptAsteroide = novoAsteroide.GetComponent<VidaAsteroide>();

        scriptAsteroide.player = FindAnyObjectByType<ControleVidaPlayer>();
    }

}
