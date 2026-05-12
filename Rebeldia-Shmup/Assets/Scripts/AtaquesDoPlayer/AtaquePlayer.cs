using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    public Transform pontoDeTiroPrimario;
    public Transform pontoDeTiroSecundario;

    public GameObject bala;
    public GameObject bala2;

    private bool podeAtirar = true;
    private bool podeAtirar2 = false;


    //Tipos de dano
    public bool normalDano = true;
    public bool fodaDano = false;

    public TiroNormal tiroNormal;


    void Update() //Apos aperta o botão esquerdo do mause para atirar, ele alterna entre os tiros (atira e chumbo)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (podeAtirar == true)
            {
                atirar();
                podeAtirar2 = true;
                podeAtirar = false;
            }

            else
            {
                chumbo();
                podeAtirar = true;
                podeAtirar2 = false;
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            normalDano = false;
            fodaDano = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            normalDano = true;
            fodaDano = false;
        }

    }

    void atirar()
    {
        GameObject novaBala = Instantiate(bala, pontoDeTiroPrimario.position, pontoDeTiroPrimario.rotation);
        TiroNormal scriptDaBala = novaBala.GetComponent<TiroNormal>();

        if (fodaDano  == true)
        {
            scriptDaBala.danoAtual = 55;
        }
        else
        {
            scriptDaBala.danoAtual = 25;
        }
    }

    void chumbo()
    {
        GameObject novaBala = Instantiate(bala2, pontoDeTiroSecundario.position, pontoDeTiroSecundario.rotation);
        TiroNormal scriptDaBala = novaBala.GetComponent<TiroNormal>();

        if (fodaDano == true)
        {
            scriptDaBala.danoAtual = 55;
        }
        else
        {
            scriptDaBala.danoAtual = 25;
        }
    }

}
