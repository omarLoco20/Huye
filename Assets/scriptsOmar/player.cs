using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public canavasManager _cManager;
    string text1 = "Lo siento, no te puedo ayudar, esa casa tiene algo misterioso, te recomiendo que salgas de ahi lo antes posible";
    string textVozPuerta = "Debo encontrar la llave para poder abrirla";
    string textVozEscalera = "Ir arriba es inutil ahora mismo";
    string txtNulo = "";
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "nota")
        {
            _cManager.pnlTextE.SetActive(true);

            if (Input.GetKeyDown("e"))
            {
                if (_cManager.pnlTextBase.activeSelf == true)
                {
                    activarYPasarTxt(text1, false);
                }
                 else if (_cManager.pnlTextBase.activeSelf == false)
                {
                    activarYPasarTxt(text1, true);

                }


            }
        }

       else if(other.gameObject.tag == "puerta")
        {
            _cManager.pnlTextE.SetActive(true);

            if (Input.GetKeyDown("e"))
            {
               
                    modifyTextVoz(textVozPuerta);
                Invoke("vaciarTextVoz",3f);            


            }
        }
       else if (other.gameObject.tag == "escalera")
        {
            _cManager.pnlTextE.SetActive(true);

            if (Input.GetKeyDown("e"))
            {

                modifyTextVoz(textVozEscalera);
                Invoke("vaciarTextVoz", 3f);


            }
        }

    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "nota" || other.gameObject.tag == "puerta" || other.gameObject.tag == "escalera")
        {
            _cManager.pnlTextE.SetActive(false);
        }
    }

    

    //crear funcion que active un panle y ese panel tenga el texto,
    //pero ese texto nosotros se lo pasaremos tendremos varios strings
    //para cada nota,

    public void activarYPasarTxt(string text,bool dependiente)
    {
        _cManager.pnlTextBase.SetActive(dependiente);
        _cManager.textPanel.text = text ;
    }

    public void modifyTextVoz(string text)
    {
        _cManager.textVox.text= text ;
    }
    public void vaciarTextVoz()
    {
        _cManager.textVox.text = txtNulo;
    }
}
