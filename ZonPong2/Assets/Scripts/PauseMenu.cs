using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : GameManager
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject victoryMenuUI;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        /*if(_pcScore.ToString() == "5")
        {
            victoryMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }*/

        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    int i = 0;

    public void MutedFunction()
    {
        if(i == 0)
        {
        AudioListener.volume = 0;
        i++;
        }

        else
        {
        AudioListener.volume = 1;
        i = 0;
        }

    }



    public void ReturnToMenu ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    /*public void ReturnToMenuEndScreen ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        victoryMenuUI.SetActive(false);
        Time.timeScale = 1f;
        

    }*/

    public void QuitGame ()
    {
        Application.Quit();
    }
}
