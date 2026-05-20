using UnityEngine;
using UnityEngine.UIElements;

public class ChunkLoop : MonoBehaviour
{
    public float velocidade = 5f;
    public int numeroDeChunks = 3;
    public int chunkSize = 100;

    public int chunkLimite = -100;



    public void Update()
    {
        transform.Translate(Vector3.back * velocidade * Time.deltaTime);
        if (transform.position.z <= chunkLimite)
        {
            transform.position = Vector3.forward * chunkSize * numeroDeChunks;
        }
    }

}
