using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_fruit : MonoBehaviour
{
    public int points;
    public int duration;
    public SnakeManager SM;
    public virtual void fruitSetup() {
        points = 100;
        duration = 8;
    }
    void Start(){
        fruitSetup();
        SM = GetComponentInParent<SnakeManager>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        SM.AddScore(points);
        SM.LengthenSnake();
        gameObject.SetActive(false);
    }
}