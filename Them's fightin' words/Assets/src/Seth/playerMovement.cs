using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // public bool isPlayer1;
    // public float speed;
    // public Rigidbody2D rb;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float movement;
    private float speed = 5f;
    public bool inNPCRange = false;
    
    public void OnCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "NPC"){
            inNPCRange = true;
            Debug.Log("In NPC Range");
        }
    }

    public void OnCollisionExit(Collision collision){
        if(collision.gameObject.tag == "NPC"){
            inNPCRange = false;
        }
    }

    public void moveUp(){
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    public void moveDown(){
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    public void moveLeft(){
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    public void moveRight(){
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    public void interact(){
        if(inNPCRange){
            Debug.Log("Call Interaction Function");
        }
    }

    void Start(){
        // transform.position = new Vector3(0,0,0);
    }
}
