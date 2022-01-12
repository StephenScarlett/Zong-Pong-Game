using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int _playerScore;
    public int _pcScore;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Ball ball;
    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;
    public AudioClip PlayMusic;

    public int scoreToReach = 3;
    public static bool GameIsPaused1 = false;

    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<AudioSource> ().clip = PlayMusic;
        GetComponent<AudioSource> ().Play ();

        
        
    }

     // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {

            if(GameIsPaused1)
            {
                Resume1();
                
            }
            else
            {
               Pause1();

            }
 
        }


    }


    public void Resume1()
    {
        GetComponent<AudioSource> ().Play ();
        GameIsPaused1 = false;
    }

    public void Pause1()
    {
        GetComponent<AudioSource> ().Pause ();
        GameIsPaused1 = true;
    }

    public void _playerScores(){
        _playerScore ++ ;
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
        if(_playerScore == scoreToReach){
            SceneManager.LoadScene(3);
            GetComponent<AudioSource> ().Stop ();
        }
    }

    public void _pcScores(){
        _pcScore++;
        this.computerScoreText.text = _pcScore.ToString();
        this.ball.ResetPosition();
        if(_pcScore == scoreToReach){
            SceneManager.LoadScene(2);
            GetComponent<AudioSource> ().Stop ();
        }
    }

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
        //Debug.LogError("Save: " + _playerScore);
        //Debug.LogError("Save: " + _pcScore);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        _playerScore = data._playerScore;
        _pcScore = data._pcScore;
        //Debug.LogError("Save: " + _playerScore);
        //Debug.LogError("Save: " + _pcScore);
        this.playerScoreText.text = data._playerScore.ToString();
        this.computerScoreText.text = data._pcScore.ToString();
        this.ball.ResetPosition();
        
        
    }


}
