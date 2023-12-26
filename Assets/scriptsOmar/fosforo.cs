using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fosforo : MonoBehaviour
{
    public Light areaLight;
    public float duracionFosforo = 10f;
    private float tiempoRestante;
    public int cantidadFosforos=40;
    public canavasManager _cManager;
    public player _player;
    string textFosforo = "Press ¨F¨";
    public scriptDJ _Dj;


    int contadorFosforo = 1;
    void Start()
    {
        actualizarTxtFosforo();
        tiempoRestante = duracionFosforo;
    }

    void Update()
    {
        // Contador de tiempo y desactivación del área de luz cuando se agote
        tiempoRestante -= Time.deltaTime;
        if (tiempoRestante <= 0)
        {
            areaLight.enabled = false;
            if (contadorFosforo >= 1)
            {
                _player.modifyTextVoz(textFosforo);
                Invoke("vaciarTextVoz", 4f);
                contadorFosforo--;
            }
           

        }

        // Encender el área de luz al presionar la tecla "f" después de 1 o 2 segundos
        if (Input.GetKeyDown(KeyCode.F)&& cantidadFosforos>=1)
        {
            if (tiempoRestante <= 0)
            {
                Invoke("EncenderFosforo", Random.Range(1f, 2f));
            }
          
        }
    }

    void EncenderFosforo()
    {
        _Dj.playFosforo();
        cantidadFosforos--;
        areaLight.enabled = true;
        tiempoRestante = duracionFosforo;
        actualizarTxtFosforo();
    }

    void actualizarTxtFosforo()
    {
        _cManager.txtFosforo.text = "FOSFOROS: " + cantidadFosforos;
    }
    public void vaciarTextVoz()
    {
        _cManager.textVox.text = "";
    }
}