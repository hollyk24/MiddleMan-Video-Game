using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SnakeManager : MonoBehaviour
{
    [SerializeField] public GameObject GAMEOVERPANEL;
    [SerializeField] public GameObject GAMEWONPANEL;
    [SerializeField] public Text scoreDisplay;
    // public static SnakeManager SM;
    public static Controls CONTROLS;
    public snakeHead SNAKEHEAD;
    public bool GameOver = false;
    private int score = 0;
    private int targetScore = 999;


    // [SerializeField] public SaveManager SM;
    public WinTracker WT;

    private void Awake() {
        // if(SM != null) SM = this;
        // else Destroy(this);

        CONTROLS = new Controls();
        SNAKEHEAD = FindObjectOfType<snakeHead>().gameObject.GetComponent<snakeHead>();
        // SM = gameObject.Find("SaveManager");
        WT = GameObject.FindGameObjectWithTag("SM").GetComponent<WinTracker>();
    }

    public void LengthenSnake(){
        SNAKEHEAD.addSnakeSegment();
    }
    public IEnumerator GAMEOVER(){
        GameOver = true;
        GAMEOVERPANEL.SetActive(true);
        WT.gameObject.transform.position = new Vector3(-1.0f,0f,0f);
        // WT.setWin(false);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("overWorld");
        // SNAKEHEAD.transform.position = new Vector3(SNAKEHEAD.transform.position.x, SNAKEHEAD.transform.position.y,SNAKEHEAD.transform.position.z - 0.001f);
        // yield return new WaitForSeconds(2);
    }

    public IEnumerator GAMEWON(){
        GameOver = true;
        GAMEWONPANEL.SetActive(true);
        WT.gameObject.transform.position = new Vector3(1.0f,0f,0f);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("overWorld");
        // Return to Overworld
    }

    public void AddScore(int i){
        score = score + i;
        scoreDisplay.text = score.ToString();
        if(score > targetScore){
            // GameOver = true;
            StartCoroutine(this.GAMEWON());
        }
    }
}
