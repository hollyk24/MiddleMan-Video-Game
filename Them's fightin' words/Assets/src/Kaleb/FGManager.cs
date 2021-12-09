using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using FightCharacter;

/*

*/
public class FGManager : MonoBehaviour
{
    #region VARS
    public Text TimeDisplay;

    public Character User;
    public NPC Enemy;

    public Slider PHealth;
    public Slider EHealth;

    public GameObject PMenu;
    public Button ExitButton;
    public Button BCButton;
    public Button TutButton;

    public float timer;
    public bool paused;
    public bool DrBC;

    public bool DisplayTut;//If the tutorial is being displayed
    public GameObject Tutorial;

    public GameObject WT;

    #endregion

    #region METHODS
    //Set some variables on load
    void Start()
    {
        WT = GameObject.FindWithTag("SM");
        timer = 50.0f;
        DrBC = false;
        DisplayTut = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!paused) {
            UpdateTimer();
            UpdateHealth();
            CheckLoss();
            CharacterPosition();
            if(Input.GetKeyDown("p")){
                PMenu.transform.Translate(-2000, 0, 0); 
                paused = true;
                Time.timeScale = 0;
            }
        } else {
            int b = Mathf.RoundToInt(timer*2);
            TimeDisplay.text = "Paused\n\n" + b.ToString();
            if(Input.GetKeyDown(KeyCode.B)){
                DrBC = !DrBC;
            }
            if(Input.GetKeyDown(KeyCode.T)){
                ShowTutorial();
            }
            if(Input.GetKeyDown(KeyCode.A) && DisplayTut == false){
                SceneManager.LoadScene("AutoPlayFight");
            }
            PauseMenu();
            UpdatePauseButtons();
        }
    }

    //Keeps both characters in the bounds of the fight and prevents them from walking through each other.
    public void CharacterPosition(){
        if(User.hurtbox.transform.position.x + 1.0f > Enemy.hurtbox.transform.position.x) {
            Enemy.hurtbox.transform.position = new Vector2(User.hurtbox.transform.position.x + 1.0f, Enemy.hurtbox.transform.position.y);
        }
        if(User.hurtbox.transform.position.x < -20.0f) {
            User.hurtbox.transform.position = new Vector2(-20.0f, Enemy.hurtbox.transform.position.y);
        }
        if(User.hurtbox.transform.position.x > 0.0f) {
            User.hurtbox.transform.position = new Vector2(0.0f, Enemy.hurtbox.transform.position.y);
        }
        if(Enemy.hurtbox.transform.position.x > 0.0f) {
            Enemy.hurtbox.transform.position = new Vector2(0.0f, Enemy.hurtbox.transform.position.y);
        }
    }

    /*The following functions are related to the pause menu*/
    public void UpdatePauseButtons() {
        Text BCText = BCButton.GetComponentInChildren<Text>(); 
        if(DrBC) {
            BCText.text = "Dr BC Mode (On)";
        } else {
            BCText.text = "Dr BC Mode (Off)";
        }
    }

    
    public void PauseMenu(){
        if(Input.GetKeyDown("p")){
            PMenu.transform.Translate(2000, 0, 0); 
            Time.timeScale = 1;
            paused = false;
        }
    }

    public void SwitchBC() {
        DrBC = !DrBC;
    }

    public void SwitchPause() {
        PMenu.transform.Translate(2000, 0, 0); 
        Time.timeScale = 1;
        paused = false;
    }

    public void ShowTutorial() {
        if(DisplayTut) {
            DisplayTut = false;
            PMenu.transform.Translate(-2000, 0, 0);
            Tutorial.transform.Translate(-2000, 0, 0);
            User.gameObject.transform.Translate(0, 0, -10);
            Enemy.gameObject.transform.Translate(0, 0, -10);
        } else {
            DisplayTut = true;
            PMenu.transform.Translate(2000, 0, 0);
            Tutorial.transform.Translate(2000, 0, 0);
            User.gameObject.transform.Translate(0, 0, 10);
            Enemy.gameObject.transform.Translate(0, 0, 10);
        }
    }

    /*Updates the timer using Unity's deltaTime*/
    public void UpdateTimer() {
        if(timer > 0) {
            timer -= Time.deltaTime;
        }
        int b = Mathf.RoundToInt(timer*2);
        TimeDisplay.text = "Time \n\n" + b.ToString();
    }

    //updates the health sliders
    public void UpdateHealth(){
        if(!DrBC) {
            PHealth.value = User.health;
        }
        EHealth.value = Enemy.health;
    }

    //checks for a loss or win condition
    public void CheckLoss() {
        if(DrBC) {
            if(Enemy.health <= 0  || timer <= 0.0f) {
                ExitWin();
            }
        } else {
            if(User.health <= 0  || timer <= 0.0f) {
                ExitLoss();
            }
            if(Enemy.health <= 0 ) {
                ExitWin();
            }
        }
    }

    public void ExitLoss() {
        WT.transform.position = new Vector3(-1.0f, 0.0f, 0.0f);
        SceneManager.LoadScene("overWorld");
    }

    //Communicate that the player won the fight to the overworld
    public void ExitWin() {
        WT.transform.position = new Vector3(1.0f, 0.0f, 0.0f);
        SceneManager.LoadScene("overWorld");
    }

    #endregion
}
