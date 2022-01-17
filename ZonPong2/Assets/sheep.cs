using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sheep : MonoBehaviour
{
    private GameObject triggeringNpc;

    private bool triggering;

    
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
