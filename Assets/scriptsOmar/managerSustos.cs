using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerSustos : MonoBehaviour
{
    public float contadorGame = 600;
    //caida de objetos
    public bool susto1=false;
    //pasos
    public bool susto2=false;
    //cruces
    public bool susto3=false;
    //cuadros
    public bool susto4=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contadorGame = contadorGame - Time.deltaTime;
        
        if(contadorGame < 500)
        {
            //pasos
            susto1 = true;
            if (contadorGame < 400)
            {
                susto2 = true;
                if (contadorGame < 300)
                {
                    susto3 = true;
                    if (contadorGame < 200)
                    {
                        susto4 = true;

                    }
                }
            }
        }


    }
}
