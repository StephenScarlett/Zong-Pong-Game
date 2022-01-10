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

    public void _playerScores(){
        _playerScore ++ ;
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
    }

    public void _pcScores(){
        _pcScore++;
        this.computerScoreText.text = _pcScore.ToString();
        this.ball.ResetPosition();
    }

    public void Victory()
    {
        if(_playerScore.ToString() == "10")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }



}
