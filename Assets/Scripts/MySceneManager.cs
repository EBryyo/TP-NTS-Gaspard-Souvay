using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public GUI quitButton;
    public GUI retryButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseGame()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        var buttons = GameObject.FindGameObjectsWithTag("Quit");
        if (buttons.Length > 0)
        {
            foreach (GameObject button in buttons)
            { 
                Destroy(button); 
            }
        }
        else
        {
            
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
