using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject mainMenuUI;
    public AudioClip MainMusic;


    void Start()
    {
        Time.timeScale = 0f;
        GetComponent<AudioSource> ().playOnAwake = true;
        GetComponent<AudioSource> ().clip = MainMusic;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void PlayGame()
    {
        mainMenuUI.SetActive(false);
        Time.timeScale = 1f;

    }



    public void QuitGame ()
    {
        Application.Quit();
    }

}
