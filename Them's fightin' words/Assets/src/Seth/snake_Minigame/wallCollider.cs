using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollider : MonoBehaviour
{
    public SnakeManager SM;
    // public bool gameOver = false;
    void Start() {
        SM = transform.parent.transform.parent.GetComponent<SnakeManager>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        // Debug.Log("OnTriggerExit2D");
        SM.GAMEOVER();
        // GameObject.Find("snakeHead").GetComponent<SnakeHead>().StopCoroutine(movementListener());
        // gameOverPanel.SetActive(true);
    }
}
