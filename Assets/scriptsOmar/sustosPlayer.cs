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
   // public Transform[] arrayCruces = new Transform[6];
    public Transform cruz1;
    public Transform cruz2;
    public Transform cruz3;
    bool susto3Play = false;

    //susto4
    public GameObject ojosAbiertos;
    public GameObject ojosCerrados;

    //cuadros
    public GameObject niña, niña1, niña2, niña3;
    public GameObject quemado, quemado1, quemado2, quemado3;
    public GameObject palo, palo1, palo2, palo3;


    //public Animator[] animador = new Animator[6];
    // Start is called before the first frame update

    private void Start()
    {
       
    }

    private void Update()
    {
        if (susto3Play) {
            rotarCruces(cruz1);
            rotarCruces(cruz2);
            rotarCruces(cruz3);
            if(cruz1.transform.rotation.x >= 90)
            {
                susto3Play=false;
            }
        }
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
            //susto1Image.SetActive(true);
            _Dj.playCualquiera(_Dj.caida);
            activar.SetActive(true);
            desactivar.SetActive(false);
            objectS1.SetActive(false);
            //cuadros
            activar1Desactivar3(niña1, niña, niña2, niña3);
            activar1Desactivar3(palo1, palo, palo2, palo3);
            activar1Desactivar3(quemado1, quemado, quemado2, quemado3);

        }

    }

    public void susto2Function()
    {
        if (_mSustos.susto2)
        {
            _Dj.playCualquiera(_Dj.pasos);
            objectS2.SetActive(false);
            //cuadros
            activar1Desactivar3(niña2, niña, niña1, niña3);
            activar1Desactivar3(palo2, palo, palo1, palo3);
            activar1Desactivar3(quemado2, quemado, quemado1, quemado3);

        }
    }

    public void susto3Function()
    {
        if (_mSustos.susto3)
        {
            susto3Play = true;
            _Dj.playCualquiera(_Dj.arrastre);
           
            objectS3.SetActive(false);
            //cuadros
            activar1Desactivar3(niña3, niña, niña2, niña1);
            activar1Desactivar3(palo3, palo, palo2, palo1);
            activar1Desactivar3(quemado3, quemado, quemado2, quemado1);

        }
    }

    public void susto4Function()
    {
        if (_mSustos.susto4)
        {
            _Dj.playCualquiera(_Dj.Boom);
            ojosCerrados.SetActive(false);

            ojosAbiertos.SetActive(true);
            objectS4.SetActive(false);

        }
    }



   

    

    public void rotarCruces(Transform obj)
    {
        // Obtén la rotación actual del objeto
        Quaternion rotacionActual = obj.transform.rotation;

        // Define la rotación deseada en el eje X (90 grados)
        Quaternion rotacionDeseada = Quaternion.Euler(90f, 0f, -90);

        // Interpola suavemente entre la rotación actual y la deseada
        obj.transform.rotation = Quaternion.Slerp(rotacionActual, rotacionDeseada, Time.deltaTime);

    }

    public void activar1Desactivar3(GameObject activar,GameObject d1,GameObject d2, GameObject d3)
    {
        activar.SetActive(true) ;
        d1.SetActive(false) ;
        d2.SetActive(false);
        d3.SetActive(false);

    }
}
