using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenScript : MonoBehaviour
{
    

    public AudioClip EndMusic;

    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<AudioSource> ().clip = EndMusic;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnToMenu ()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        GetComponent<AudioSource> ().Stop ();

    }

    public void QuitGame ()
    {
        Application.Quit();
    }



}
