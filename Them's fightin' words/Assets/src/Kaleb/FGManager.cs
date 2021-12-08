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

    public bool DiplayTut;//If the tutorial is being displayed
    public GameObject Tutorial;

    #endregion

    #region METHODS
    //Set some variables on load
    void Start()
    {
        timer = 50.0f;
        DrBC = false;
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
                PMenu.transform.Translate(-1000, 0, 0); 
                paused = true;
                Time.timeScale = 0;
            }
        } else {
            int b = Mathf.RoundToInt(timer*2);
            TimeDisplay.text = "Paused\n\n" + b.ToString();
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
            PMenu.transform.Translate(1000, 0, 0); 
            Time.timeScale = 1;
            paused = false;
        }
    }

    public void SwitchBC() {
        DrBC = !DrBC;
    }

    public void SwitchPause() {
        PMenu.transform.Translate(1000, 0, 0); 
        Time.timeScale = 1;
        paused = false;
    }

    public void ExitLoss() {

    }

    public void ShowTutorial() {

    }

    /*Checks that */
    public void UpdateTimer() {
        if(timer > 0) {
            timer -= Time.deltaTime;
        }
        int b = Mathf.RoundToInt(timer*2);
        TimeDisplay.text = "Time \n\n" + b.ToString();
    }

    public void UpdateHealth(){
        if(!DrBC) {
            PHealth.value = User.health;
        }
        EHealth.value = Enemy.health;
    }

    public void CheckLoss() {
        if(DrBC) {
            if(Enemy.health <= 0  || timer <= 0.0f) {
                Debug.Log("You Win!");
                SceneManager.LoadScene("overWorld");
            }
        } else {
            if(User.health <= 0  || timer <= 0.0f) {
                Debug.Log("Game Over");
                SceneManager.LoadScene("overWorld");
            }
            if(Enemy.health <= 0 ) {
                Debug.Log("You Win!");
                SceneManager.LoadScene("overWorld");
            }
        }
    }
    #endregion
}
