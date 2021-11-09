using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake_fruit : MonoBehaviour
{
    // Start is called before the first frame update
    // public Sprite newSprite;
    public int points;

    public virtual void fruitSetup() {
        points = 1;
    }

    void Start(){
        fruitSetup();
    }
    void OnTriggerEnter2D(Collider2D col)
    // void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("OnTriggerExit2D");
        gameObject.SetActive(false);
        // gameOver = true;
        // gameOverPanel.SetActive(true);
    }
}