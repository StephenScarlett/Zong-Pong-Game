using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData
{
    public int _playerScore;
    public int _pcScore;
    public string userVal1;
    public string userVal2;
    public string userVal3;
    
    public PlayerData (GameManager player){
        _playerScore = player._playerScore;
        _pcScore = player._pcScore;
        userVal1 = player.userVal1;
        userVal2 = player.userVal2;
        userVal3 = player.userVal3;
    }
}
