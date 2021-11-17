using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class SnakeManager : MonoBehaviour
{
    [SerializeField] public GameObject GAMEOVERPANEL;
    [SerializeField] public GameObject GAMEWONPANEL;
    [SerializeField] public Text scoreDisplay;
    public static SnakeManager SM;
    public static Controls CONTROLS;
    public snakeHead SNAKEHEAD;
    public bool GameOver = false;
    private int score = 0;
    private void Awake() {
        if(SM != null) SM = this;
        else Destroy(this);

        CONTROLS = new Controls();
        SNAKEHEAD = FindObjectOfType<snakeHead>().gameObject.GetComponent<snakeHead>();
    }

    public void LengthenSnake(){
        SNAKEHEAD.addSnakeSegment();
    }
    public void GAMEOVER(){
        GameOver = true;
        GAMEOVERPANEL.SetActive(true);
        SNAKEHEAD.transform.position = new Vector3(SNAKEHEAD.transform.position.x, SNAKEHEAD.transform.position.y,SNAKEHEAD.transform.position.z - 0.001f);
        // yield return new WaitForSeconds(2);
    }

    public void GAMEWON(){
        GameOver = true;
        GAMEWONPANEL.SetActive(true);
        SNAKEHEAD.transform.position = new Vector3(SNAKEHEAD.transform.position.x, SNAKEHEAD.transform.position.y,SNAKEHEAD.transform.position.z - 0.001f);
        // yield return new WaitForSeconds(2);
        // Return to Overworld
    }

    public void AddScore(int i){
        score = score + i;
        scoreDisplay.text = score.ToString();
        if(score > 1000){
            this.GAMEWON();
        }
    }
    public bool Apple = false;
    public void AddToInventory(int i){
        switch(i){
            case 0:
                Apple = true;
                break;
        }
    }
}
