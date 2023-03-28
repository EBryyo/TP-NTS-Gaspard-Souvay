using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public GameObject quitButton;
    public GameObject retryButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton.SetActive(false);
        retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseGame()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        if (quitButton.activeInHierarchy)
        {
            quitButton.SetActive(false);
            retryButton.SetActive(false);
        }
        else
        {
            quitButton.SetActive(true);
            retryButton.SetActive(true);
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
