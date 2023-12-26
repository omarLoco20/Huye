using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptDJ : MonoBehaviour
{

    public AudioSource ass;
    public AudioClip fosforo;
    public AudioClip grito;
    public AudioClip respiracion;

    // Start is called before the first frame update
   
    public void playFosforo()
    {
        ass.PlayOneShot(fosforo);
    }
    public void playGrito()
    {
        ass.PlayOneShot(grito);
    }
}
