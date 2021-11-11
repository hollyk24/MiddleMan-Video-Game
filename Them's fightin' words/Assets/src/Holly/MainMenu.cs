using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public bool gamerunning = false;


    public void StartGame() {
        gamerunning = true;
            SceneManager.LoadScene("overWorld");
            AudioManager.Play(AudioLibrary.Library.Select);
            //Debug.Log("Starting Game");
    }

    public void QuitGame() {

            Debug.Log("QUIT!");
            AudioManager.Play(AudioLibrary.Library.Select);
            Application.Quit();
    }

    public void SettingGame() {
        SceneManager.LoadScene("SettingsMenu");
        AudioManager.Play(AudioLibrary.Library.Select);
        //Debug.Log("Settings");
    }
    public void InstructionsGame() {
            SceneManager.LoadScene("InstructionsMenu");
            //Debug.Log("Instructions");
    }




    void Update() {
            if (Input.GetKeyDown(KeyCode.P)) {
                SceneManager.LoadScene("lilyTestScene");
            }
            if (Input.GetKeyDown(KeyCode.Q)) {
                Debug.Log("Quit");
                Application.Quit();
            }
            if (Input.GetKeyDown(KeyCode.I)) {
                SceneManager.LoadScene("Instructions");
            }
            if (Input.GetKeyDown(KeyCode.S)) {
                SceneManager.LoadScene("SettingsMenu");
            }

    }

}

/*
static MainMenu instance;

void Awake(){
    if (instance != null){
        Destroy(gameObject);
    }
    else{
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
*/







