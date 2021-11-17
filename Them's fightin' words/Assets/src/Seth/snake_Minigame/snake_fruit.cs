using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_fruit : MonoBehaviour
{
    public int points;
    public int duration;
    public SnakeManager SM;
    public fruitSpawner FS;
    public virtual void fruitSetup() {
        points = 100;
        duration = 8;
    }
    void Awake(){
        fruitSetup();
        FS = transform.parent.GetComponent<fruitSpawner>();
        if(FS == null){
            Debug.Log("Couldn't find FS");
        }
        SM = transform.parent.transform.parent.GetComponent<SnakeManager>();
        if(SM == null){
            Debug.Log("Couldn't find SM");
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        SM.AddScore(points);
        SM.LengthenSnake();
        FS.fruitNeedsSpawned();
        gameObject.SetActive(false);
    }
}