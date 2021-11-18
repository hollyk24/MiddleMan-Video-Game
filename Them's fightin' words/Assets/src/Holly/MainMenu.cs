/*
* FileName: MainMenu.cs
* Developer: Holly Keir
* Purpose: This file is used to control the main menu scene
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*
* A class that calls a function for each button on the menu screen
* 
* Member Variables:
* 
*/
public class MainMenu : MonoBehaviour 
{

    public bool GameRunning = false;

    /*
    * Used to accept key presses for each scene change
    */
    void Update() {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            SceneManager.LoadScene("overWorld");
        }
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Debug.Log("Quit");
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            SceneManager.LoadScene("Instructions");
        }
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            SceneManager.LoadScene("SettingsMenu");
        }

    }

    /*
    * Function to set the GameRunning variable to true when the overWorld scene is loaded
    * The function is called when the button is selected and holds the audiolibrary for the scene
    */
    public void StartGame() 
    {
        GameRunning = true;
        SceneManager.LoadScene("overWorld");
        AudioManager.Play(AudioLibrary.Library.Select);
        //Debug.Log("Starting Game");
    }

    /*
    * Function to exit the game. Uses unity function and quits the application
    * GameRunning is set to false and audio manager stops music
    */
    public void QuitGame() 
    {
        //Debug.Log("QUIT!");
        AudioManager.Play(AudioLibrary.Library.Select);
        GameRunning = false;
        Application.Quit();
    }

    /*
    * Loads the settings Menu and loads a new music file
    */  
    public void SettingGame() 
    {
        SceneManager.LoadScene("SettingsMenu");
        AudioManager.Play(AudioLibrary.Library.Select);
        //Debug.Log("Settings");
    }
    
    /*
    * Loads the Instructions Menu
    */
    public void InstructionsGame() 
    {
        SceneManager.LoadScene("InstructionsMenu");
        //Debug.Log("Instructions");
    }

}

