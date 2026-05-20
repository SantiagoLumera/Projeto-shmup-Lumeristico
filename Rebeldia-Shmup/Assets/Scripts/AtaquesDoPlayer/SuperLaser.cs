using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class SuperLaser : MonoBehaviour
{
    public int danoDoLaser = 50;

    public float tempoDoDano;

    public bool laserDanoAtivo = true;



    private void Update()
    {
        if (tempoDoDano > 0)
        {
            tempoDoDano -= Time.deltaTime;
            if (tempoDoDano < 0)
            {
                tempoDoDano = 0;
                laserDanoAtivo = true;
            }
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo") && laserDanoAtivo == true)
        {
            laserDanoAtivo = false;
            tempoDoDano = 2f;
        }     
            
    }


}
