using UnityEngine;

public class Habilidades : MonoBehaviour
{
    public AtaquePlayer player;
    public SuperLaser laser;


    public float tempoBerserk;
    public float cooldownBerserk;

    public float superLaserTempo;
    public float cooldownLaser;

    private void Update()
    {

        //Modo Berserk
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (tempoBerserk <= 0 && cooldownBerserk <= 0)
            {
                tempoBerserk = 5f;
                player.fireRate = 0.1f;
                player.danoID = 2;
            }
        }

        if (cooldownBerserk > 0)
        {
            cooldownBerserk -= Time.deltaTime;
            if (cooldownBerserk <= 0)
            {
                tempoBerserk = 0;
                cooldownBerserk = 0;
            }
        }
        
        if (tempoBerserk > 0)
        {   
            tempoBerserk -= Time.deltaTime;
            if (tempoBerserk <= 0)
            {
                player.danoID = 0;
                player.fireRate = 0.5f;
                cooldownBerserk  = 5f;
            }
        }

        //Solta o Laser
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (superLaserTempo <= 0 && cooldownLaser <= 0)
            {
                laser.gameObject.SetActive(true);
                superLaserTempo = 8f; 
            }
        }

        if (cooldownLaser > 0)
        {

            cooldownLaser -= Time.deltaTime;
            if (cooldownLaser <= 0)
            {
                cooldownLaser = 0;
                superLaserTempo = 0;
            }
        }

        if (superLaserTempo > 0)
        {

            superLaserTempo -= Time.deltaTime;
            if (superLaserTempo <= 0)
            {
                superLaserTempo = 0;
                cooldownLaser = 5f;
                laser.gameObject.SetActive(false);
            }
        }




    } 
}
