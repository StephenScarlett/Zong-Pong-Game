using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioClip StartMusic;

    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<AudioSource> ().clip = StartMusic;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        GetComponent<AudioSource> ().Stop ();

    }


    public void QuitGame ()
    {
        Application.Quit();
    }

}
