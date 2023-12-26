using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sustosPlayer : MonoBehaviour
{
    public GameObject susto1Image;
    public scriptDJ _Dj;
    // Start is called before the first frame update
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "susto1")
        {
            susto1Function();
        }
    }

    public void susto1Function()
    {
        susto1Image.SetActive(true);
        _Dj.playGrito();

        Invoke("desactivarImage", 1.5f);
    }

    public void desactivarImage()
    {
        susto1Image.SetActive(false);
    }
}
