using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData
{
    public int _playerScore;
    public int _pcScore;
    
    public PlayerData (GameManager player){
        _playerScore = player._playerScore;
        _pcScore = player._pcScore;
    }
}
