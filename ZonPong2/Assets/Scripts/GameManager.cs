using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

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
    public GameObject mainMenuUI;
    public AudioSource No_Sound;
    public GameObject inputUI;
    public TMP_InputField ipUser;
    public GameObject save1;
    public GameObject save2;
    public GameObject save3;
    public GameObject load1;
    public GameObject load2;
    public GameObject load3;
    

    public int scoreToReach = 3;
    public static bool GameIsPaused1 = false;
    private int checker;
    public string userVal1;
    public string userVal2;
    public string userVal3;

    // Start is called before the first frame update
    void Start()
    {
        load1.GetComponent<Button>();
        load2.GetComponent<Button>();
        load3.GetComponent<Button>();
        save1.GetComponent<Button>();
        save2.GetComponent<Button>();
        save3.GetComponent<Button>();
        
        PlayerData data1 = SaveSystem.LoadPlayer();
        PlayerData data2 = SaveSystem.LoadPlayer2();
        PlayerData data3 = SaveSystem.LoadPlayer3();

        userVal1 = data1.userVal1;
        userVal2 = data2.userVal2;
        userVal3 = data3.userVal3;

        if (string.IsNullOrEmpty(userVal1))
        {
            userVal1 = "SLOT 1";
        }

        if (string.IsNullOrEmpty(userVal2))
        {
            userVal2 = "SLOT 2";
        }

        if (string.IsNullOrEmpty(userVal3))
        {
            userVal3 = "SLOT 3";
        }
        
        load1.GetComponentInChildren<TMP_Text>().text = userVal1;
        load2.GetComponentInChildren<TMP_Text>().text = userVal2;
        load3.GetComponentInChildren<TMP_Text>().text = userVal3;
        save1.GetComponentInChildren<TMP_Text>().text = userVal1;
        save2.GetComponentInChildren<TMP_Text>().text = userVal2;
        save3.GetComponentInChildren<TMP_Text>().text = userVal3;

        


    }

     // Update is called once per frame
    void Update()
    {

        if (string.IsNullOrEmpty(userVal1))
        {
            userVal1 = "SLOT 1";
        }

        if (string.IsNullOrEmpty(userVal2))
        {
            userVal2 = "SLOT 2";
        }

        if (string.IsNullOrEmpty(userVal3))
        {
            userVal3 = "SLOT 3";
        } 

        load1.GetComponentInChildren<TMP_Text>().text = userVal1;
        load2.GetComponentInChildren<TMP_Text>().text = userVal2;
        load3.GetComponentInChildren<TMP_Text>().text = userVal3;
        save1.GetComponentInChildren<TMP_Text>().text = userVal1;
        save2.GetComponentInChildren<TMP_Text>().text = userVal2;
        save3.GetComponentInChildren<TMP_Text>().text = userVal3; 
    }


    public void _playerScores(){
        _playerScore ++ ;
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
        if(_playerScore == scoreToReach){

            SaveSystem.SavePlayer4(this);
            SceneManager.LoadScene(3);
            GetComponent<AudioSource> ().Stop ();
        }
    }

    public void _pcScores(){
        _pcScore++;
        this.computerScoreText.text = _pcScore.ToString();
        this.ball.ResetPosition();
        if(_pcScore == scoreToReach){

            SaveSystem.SavePlayer4(this);
            SceneManager.LoadScene(2);
            GetComponent<AudioSource> ().Stop ();
        }
    }

    public void SavePlayer ()
    {
        

        inputUI.SetActive(true);

        checker = 1;

    }

    public void SavePlayer2 ()
    {
        
        inputUI.SetActive(true);
        checker = 2;
    }

    public void SavePlayer3 ()
    {
        
        inputUI.SetActive(true);
        checker = 3;
    }

    public void GetInput(string userInput)
    {

        ipUser.text = "";
        inputUI.SetActive(false);

        if(checker == 1)
        {
            save1.GetComponent<Button>();
            save1.GetComponentInChildren<TMP_Text>().text = userInput;
            userVal1 = userInput;
            SaveSystem.SavePlayer(this);
             

        }

        if(checker == 2)
        {
             save2.GetComponent<Button>();
             save2.GetComponentInChildren<TMP_Text>().text = userInput;
             userVal2 = userInput;
             SaveSystem.SavePlayer2(this);
        }

        if(checker == 3)
        {
             //save3.GetComponent<Button>();
             //save3.GetComponentInChildren<TMP_Text>().text = userInput;
             userVal3 = userInput;
             SaveSystem.SavePlayer3(this);

        }
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        if(data != null)
        {
            _playerScore = data._playerScore;
            _pcScore = data._pcScore;

            this.playerScoreText.text = data._playerScore.ToString();
            this.computerScoreText.text = data._pcScore.ToString();

            mainMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }

        else
        {
            No_Sound.Play();
        }
        
        
    }
    
    public void LoadProfile ()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        PlayerData data2 = SaveSystem.LoadPlayer2();
        PlayerData data3 = SaveSystem.LoadPlayer3();

        userVal1 = "LOAD SLOT 1";
        userVal2 = "LOAD SLOT 2";
        //userVal3 = "LOAD SLOT 3";


        if(data.userVal1 != null)
        {
            userVal1 = data.userVal1;
            load1.GetComponent<Button>();
            load1.GetComponentInChildren<TMP_Text>().text = userVal1;
        }
        

        if(data.userVal2 != null)
        {
            userVal2 = data2.userVal2;
            load2.GetComponent<Button>();
            load2.GetComponentInChildren<TMP_Text>().text = userVal2;
        }    
            

 
            userVal3 = data3.userVal3;
            

            //mainMenuUI.SetActive(false);
        
        
    }

    public void LoadPlayer2 ()
    {
        PlayerData data = SaveSystem.LoadPlayer2();


        if(data != null)
        {
            _playerScore = data._playerScore;
            _pcScore = data._pcScore;

            this.playerScoreText.text = data._playerScore.ToString();
            this.computerScoreText.text = data._pcScore.ToString();

            mainMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }

        else
        {
            No_Sound.Play();
        }
        
        
    }

    public void LoadPlayer3 ()
    {
        PlayerData data = SaveSystem.LoadPlayer3();

        if(data != null)
        {
            _playerScore = data._playerScore;
            _pcScore = data._pcScore;

            this.playerScoreText.text = data._playerScore.ToString();
            this.computerScoreText.text = data._pcScore.ToString();
 
            mainMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }

        else
        {
            No_Sound.Play();
        }
        
        
    }

    public static void DeleteSave1()
     {
         string path = Application.persistentDataPath + "/player.fun";
         File.Delete(path);
         
     }

     public static void DeleteSave2()
     {
         string path = Application.persistentDataPath + "/player2.fun";
         File.Delete(path);
     }

     public static void DeleteSave3()
     {
         string path = Application.persistentDataPath + "/player3.fun";
         File.Delete(path);
         
     }

     public void dlt1()
     {
         userVal1 = "SLOT 1";
     }

     public void dlt2()
     {
         userVal2 = "SLOT 2";
     }

     public void dlt3()
     {
         userVal3 = "SLOT 3";
     }

    public void ResetScores()
    {
        _playerScore = 0;
        _pcScore = 0;
        this.playerScoreText.text = "0";
        this.computerScoreText.text = "0";
    }


}
