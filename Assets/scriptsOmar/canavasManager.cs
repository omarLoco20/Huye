using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
public class canavasManager : MonoBehaviour
{
    public GameObject pnlTextE;
    public GameObject pnlTextBase;
    public GameObject pnlPause;
    public GameObject pnlScreemer;
    public Text textPanel;
    public Text textVox;
    public Text txtFosforo;
    public GameObject pnlThanks;


    private bool panelActivo = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        // Verifica si se presiona el botón "Esc"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Activa o desactiva el panel y muestra u oculta el cursor
            panelActivo = !panelActivo;
            pnlPause.SetActive(panelActivo);
            Cursor.visible = panelActivo;
            Cursor.lockState = panelActivo ? CursorLockMode.Confined : CursorLockMode.Locked;
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }

  

}
