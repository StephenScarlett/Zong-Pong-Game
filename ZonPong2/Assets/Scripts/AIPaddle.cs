using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : Paddle
{
    public AudioClip woof;
    public Rigidbody2D ball;

    void Start ()   
     {
         GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = woof;
     }  
    

    private void FixedUpdate(){
        if(this.ball.velocity.x > 0.0f){
            if(this.ball.position.y > this.transform.position.y){
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if(this.ball.position.y < this.transform.position.y){
                _rigidbody.AddForce(Vector2.down*this.speed);
            }
        }
        else{
            if(this.transform.position.y > 0.0f ){
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Ball ball = collision.gameObject.GetComponent<Ball>();
        
        if (ball != null){
            GetComponent<AudioSource> ().Play ();
        }
        
        }
    
}
