using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sustosPlayer : MonoBehaviour
{
    public GameObject susto1Image;
    public scriptDJ _Dj;
    public managerSustos _mSustos;
    public GameObject objectS1,objectS2, objectS3, objectS4;
    //susto 1
    public GameObject activar;
    public GameObject desactivar;

    //susto3
    public GameObject[] arrayCruces = new GameObject[6];
    //public Animator[] animador = new Animator[6];
    // Start is called before the first frame update

    private void Start()
    {
        /*for (int i = 0; i < arrayCruces.Length; i++)
        {
            animador[i] = arrayCruces[i].GetComponent<Animator>();
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "susto1")
        {
            susto1Function();
            
        }
        if (other.gameObject.tag == "susto2")
        {
            susto2Function();

        }
        if (other.gameObject.tag == "susto3")
        {
            susto3Function();

        }
        if (other.gameObject.tag == "susto4")
        {
            susto4Function();

        }
    }

    public void susto1Function()
    {
        if (_mSustos.susto1)
        {
            susto1Image.SetActive(true);
            _Dj.playCualquiera(_Dj.caida);
            activar.SetActive(true);
            desactivar.SetActive(false);
            objectS1.SetActive(false);
        }

    }

    public void susto2Function()
    {
        if (_mSustos.susto2)
        {
            _Dj.playCualquiera(_Dj.pasos);
            objectS2.SetActive(false);
        }
    }

    public void susto3Function()
    {
        if (_mSustos.susto3)
        {
            _Dj.playCualquiera(_Dj.arrastre);
           
            objectS3.SetActive(false);
        }
    }

    public void susto4Function()
    {
        if (_mSustos.susto4)
        {
            _Dj.playCualquiera(_Dj.pasos);
        }
    }



   

    /*public void activarAnimadores()
    {
        for (int i = 0; i < arrayCruces.Length; i++)
        {
            animador[i].SetBool("activar",true);
        }


    }*/

    public void rotarCruces()
    {
        while (arrayCruces[0].transform.rotation.x>90)
        {

        }
    }
}
