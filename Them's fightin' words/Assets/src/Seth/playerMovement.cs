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
    public float speed = 5f;
    public bool inNPCRange = false;
    Animator animator;
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
        animator.SetTrigger("Up");
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    public void moveDown(){
        animator.SetTrigger("Down");
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    public void moveLeft(){
        animator.SetTrigger("Left");
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    public void moveRight(){
        animator.SetTrigger("Right");
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    public void interact(){
        if(inNPCRange){
            Debug.Log("Call Interaction Function");
        }
    }

    void Start(){
        // transform.position = new Vector3(0,0,0);
        animator = GetComponent<Animator>();
    }
}
