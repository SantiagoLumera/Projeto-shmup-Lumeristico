using Unity.VisualScripting;
using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    public Transform pontoDeTiroPrimario;
    public Transform pontoDeTiroSecundario;

    public GameObject bala;

    public float tempoEntreTiros = 0.5f;
    public float fireRate;

    private bool podeAtirar = true;


    public float tempoTiroFoda;
    public float CooldownTiroFoda;


    public int[] danoNormal = new int[] { 25, 45, 65,};
    public int danoID = 0; 

    void Update()
    {

        /*if (CooldownTiroFoda > 0) 
        {
            CooldownTiroFoda -= Time.deltaTime;
            if (CooldownTiroFoda < 0)
            {
                CooldownTiroFoda = 0;
            }
        }

        if (tempoTiroFoda > 0)
        {
            tempoTiroFoda -= Time.deltaTime;
            if (tempoTiroFoda <= 0)
            {
                tempoTiroFoda = 0;
                danoID = 0;
                CooldownTiroFoda = 5f;
            }
        }*/

        if (tempoEntreTiros > 0)
        {
            tempoEntreTiros -= Time.deltaTime; 
        }


        if (Input.GetKey(KeyCode.Mouse0) && tempoEntreTiros <= 0) //Apos aperta o botão esquerdo do mouse para atirar, ele alterna entre os tiros (atira e chumbo)
        {
            if (podeAtirar == true)
            {   
                atirar();
                tempoEntreTiros = fireRate;
                podeAtirar = false;
            }

            else 
            {
                chumbo();
                tempoEntreTiros = fireRate;
                podeAtirar = true;
            }
        }

        /*if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (tempoTiroFoda <= 0 && CooldownTiroFoda <= 0)
            {
                tempoTiroFoda = 5f;
                danoID = 3;
            }
            
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            danoID = 1;
        }*/

    }

    void atirar()
    {
        GameObject novaBala = Instantiate(bala, pontoDeTiroPrimario.position, pontoDeTiroPrimario.rotation);
        TiroNormal scriptDaBala = novaBala.GetComponent<TiroNormal>();

            switch (danoID)
        {
            case 0:
                scriptDaBala.danoAtual = danoNormal[0];
                break;
            case 1:
                scriptDaBala.danoAtual = danoNormal[1];
                break;
            case 2:
                scriptDaBala.danoAtual = danoNormal[2];
                break;
            default:
                scriptDaBala.danoAtual = danoNormal[0];
                break;
        }

    }

    void chumbo()
    {
        GameObject novaBala = Instantiate(bala, pontoDeTiroSecundario.position, pontoDeTiroSecundario.rotation);
        TiroNormal scriptDaBala = novaBala.GetComponent<TiroNormal>();

        switch (danoID)
        {
            case 0:
                scriptDaBala.danoAtual = danoNormal[0];
                break;
            case 1:
                scriptDaBala.danoAtual = danoNormal[1];
                break;
            case 2:
                scriptDaBala.danoAtual = danoNormal[2];
                break;
            default:
                scriptDaBala.danoAtual = danoNormal[0];
                break;
        }
    }

    void modoBerserk()
    {
        danoID = 3;
    }

}
