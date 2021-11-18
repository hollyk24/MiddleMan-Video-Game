using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_fruit : MonoBehaviour
{
    public SnakeManager SM;
    public fruitSpawner FS;
    void Awake(){
        FS = transform.parent.GetComponent<fruitSpawner>();
        if(FS == null){
            Debug.Log("Couldn't find FS");
        }
        SM = transform.parent.transform.parent.GetComponent<SnakeManager>();
        if(SM == null){
            Debug.Log("Couldn't find SM");
        }
    }
    public virtual void OnTriggerEnter2D(Collider2D col)
    {
        SM.LengthenSnake();
        FS.fruitNeedsSpawned();
        gameObject.SetActive(false);
    }
}