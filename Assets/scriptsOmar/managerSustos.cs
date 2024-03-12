using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerSustos : MonoBehaviour
{
    public scriptDJ _dj;
    public sustosPlayer _sustosP;
    public canavasManager _cManager;
    public GameObject pnlThanks;
    //public player _player;
    public float contadorGame = 600;
    //caida de objetos
    public bool susto1=false;
    //pasos
    public bool susto2=false;
    //cruces
    public bool susto3=false;
    //cuadros
    public bool susto4=false;
    //screemer
    public bool susto5=false;
    public bool susto6=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contadorGame = contadorGame - Time.deltaTime;
        /*
        if(contadorGame < 550)
        {
            //pasos
            susto1 = true;
            if (contadorGame < 500)
            {
                susto2 = true;
                if (contadorGame < 450)
                {
                   
                    susto3 = true;
                    if (contadorGame < 400)
                    {
                        _sustosP._player.modifyTextVoz(_sustosP.irCuadros);
                        susto4 = true;
                        if (contadorGame < 350)
                        {
                            susto5=true;
                            _sustosP._player.vaciarTextVoz();

                            if (contadorGame < 300)
                            {
                                //campanas
                                _dj.playCualquiera(_dj.campanas);
                            }
                            
                        }
                    }
                }
            }
        }*/

        if (contadorGame < 550 && susto1==false )
        {
            //pasos
            susto1 = true;
        }else if(contadorGame < 500&& susto2 == false)
        {
            susto2 = true;
        }
        else if (contadorGame < 450 && susto3 == false)
        {
            susto3 = true;
        }
        else if (contadorGame < 400 && susto4 == false)
        {
            _sustosP._player.modifyTextVoz(_sustosP.irCuadros);
            susto4 = true;
        }
        else if (contadorGame < 350 && susto5 == false)
        {
            susto5 = true;
            _sustosP._player.vaciarTextVoz();
        }
        else if (contadorGame < 300 )
        {
            //campanas
            _dj.playCualquiera(_dj.campanas);
        }
         if (contadorGame < 250 && susto6 == false)
        {
            //panel gracias Demo
            susto6=true;
        }


    }

    public void activarPnlFinal()
    {
        pnlThanks.SetActive(true);
        Cursor.visible = true;
    }
}
