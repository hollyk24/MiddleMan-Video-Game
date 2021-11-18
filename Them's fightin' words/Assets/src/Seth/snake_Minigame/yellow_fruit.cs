using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow_fruit : snake_fruit
{
    int points = 500; // "Decorator" part
    public override void OnTriggerEnter2D(Collider2D col) // Dynamic Binding
    {
        SM.AddScore(points);
        FS.fruitNeedsSpawned();
        gameObject.SetActive(false);
    }
}
