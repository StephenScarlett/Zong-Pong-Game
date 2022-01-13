using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : GameManager
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject mainMenuUI1;
    //public AudioClip PauseMusic;

// Start is called before the first frame update
    void Start()
    {
        //GetComponent<AudioSource> ().playOnAwake = false;
        //GetComponent<AudioSource> ().clip = PauseMusic;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) &&  mainMenuUI1.activeInHierarchy == false)
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


        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        //GetComponent<AudioSource> ().Stop ();

    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        //GetComponent<AudioSource> ().Play ();
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

        mainMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = false;
        ball.ResetPosition();

    }


    public void QuitGame ()
    {
        Application.Quit();
    }
}
