using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptDJ : MonoBehaviour
{

    public AudioSource ass;
    public AudioClip fosforo;
    public AudioClip grito;
    public AudioClip respiracion;
    public AudioClip arrastre;
    public AudioClip caida;
    public AudioClip puertaChillido;
    public AudioClip pasos;
    public AudioClip Boom;
    public AudioClip campanas;

    // Start is called before the first frame update
   
    public void playFosforo()
    {
        ass.PlayOneShot(fosforo);
    }
    public void playGrito()
    {
        ass.PlayOneShot(grito);
    }

    public void playCualquiera(AudioClip clip)
    {
        ass.PlayOneShot(clip);

    }
}
