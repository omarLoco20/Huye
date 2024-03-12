using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptScene : MonoBehaviour
{
    public string sceneGame;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
        
    }
    public void play()
    {
        SceneManager.LoadScene(sceneGame);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");

    }
}