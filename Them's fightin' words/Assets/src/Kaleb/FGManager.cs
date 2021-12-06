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
    public Player User;
    public NPC Enemy;
    public Slider PHealth;
    public Slider EHealth;
    public float timer;
    public bool paused;
    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Start()
    {
        timer = 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!paused) {
            UpdateTimer();
            UpdateHealth();
            CheckLoss();
            if(Input.GetKeyDown("p")){
                paused = true;
                Time.timeScale = 0;
            }
        } else {
            int b = Mathf.RoundToInt(timer*2);
            TimeDisplay.text = "Paused\n\n" + b.ToString();
            PauseMenu();
        }
    }

    void PauseMenu(){
        if(Input.GetKeyDown("p")){
            Time.timeScale = 1;
            paused = false;
        }
    }

    void UpdateTimer() {
        if(timer > 0) {
            timer -= Time.deltaTime;
        }
        int b = Mathf.RoundToInt(timer*2);
        TimeDisplay.text = "Time \n\n" + b.ToString();
    }

    void UpdateHealth(){
        PHealth.value = User.health;
        EHealth.value = Enemy.health;
    }

    void CheckLoss() {
        if(User.health <= 0 || Enemy.health <= 0  || timer <= 0.0f) {
            Debug.Log("Game Over");
            SceneManager.LoadScene("overWorld");
        }
    }
    #endregion
}
