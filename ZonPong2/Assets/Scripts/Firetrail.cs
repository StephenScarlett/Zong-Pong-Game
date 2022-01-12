using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firetrail : MonoBehaviour
{

    
    public int count;
    public ParticleSystem fire;
    

    // Start is called before the first frame update
    void Start()
    {
        fire.Stop();
        count = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision ){
        Ball ball = collision.gameObject.GetComponent<Ball>();
        ScoringZone lw = collision.gameObject.GetComponent<ScoringZone>();

        
            count++;
        

        if (lw != null  ){
           count = 0;
           fire.Stop();
        }


    
    }

    

    // Update is called once per frame
    void Update()
    {

       

        if(count >= 11){
            fire.Play();
        }



    }





}
