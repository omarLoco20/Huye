using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public canavasManager _cManager;
    string text1 = "Perdona que te diga esto de esta forma, decidi huir, no aguante mas esta situacion";
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
       
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "nota")
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
}
