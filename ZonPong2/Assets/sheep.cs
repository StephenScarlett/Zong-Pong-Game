using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class sheep : MonoBehaviour
{
    private GameObject triggeringNpc;
    public TMP_Text load1;
    public TMP_Text load2;

    private string userVal1;
    private string userVal2;

    private bool triggering;

    void Start()
    {
        PlayerData data1 = SaveSystem.LoadPlayer4();
        userVal1 = data1._playerScore.ToString();
        userVal2 = data1._pcScore.ToString();

        if (string.IsNullOrEmpty(userVal1))
        {
            userVal1 = "Player Score = 0";
        }

        if (string.IsNullOrEmpty(userVal2))
        {
            userVal1 = "PC Score = 0";
        }

        load1.text = "Player Score = " + userVal2;
        load2.text = "PC Score = " + userVal1;
        
    }
    
    void Update(){
        if(triggering){
            if(Input.GetKey(KeyCode.F)){
                SceneManager.LoadScene(1);
            }
            

        }

        

        

        
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "NPC"){
            triggering = true;
            triggeringNpc = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.tag == "NPC"){
            triggering = false;
            triggeringNpc = null;
        }
    }


}
