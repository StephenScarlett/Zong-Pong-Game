using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColourChanger : MonoBehaviour
{

    SpriteRenderer sprite;
    public int count;
    public ParticleSystem fire;
    public ParticleSystem ballchange;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        fire.Stop();
        count = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision ){
        Ball ball = collision.gameObject.GetComponent<Ball>();
        ScoringZone lw = collision.gameObject.GetComponent<ScoringZone>();
        //Rightwall rw = collision.gameObject.GetComponent<Rightwall>();

        
            count++;
        

        if (lw != null /* || rw != null*/ ){
           count = 0;
           fire.Stop();
        }


    
    }

    

    // Update is called once per frame
    void Update()
    {
        

        if (count <= 5){
            sprite.color = new Color(1,1,1,1);   
        }

        if(count == 5){
            ballchange.Play();
        }

        if(count == 11){
            ballchange.Play();
        }

        if(count > 5 && count < 11){
            sprite.color = new Color(1, 0.3f, 0.3f, 1);   
        }

        if(count >= 11){
            sprite.color = new Color(1,0,0,1);
            fire.Play();
        }
    }




}
