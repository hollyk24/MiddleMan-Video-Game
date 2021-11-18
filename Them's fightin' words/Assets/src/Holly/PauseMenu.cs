/*
* FileName: PauseMenu.cs
* Developer: Holly Keir
* Purpose: This file is the pause menu
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
* A class to control the pause menu and determine when it is active
*/
public class PauseMenu : MonoBehaviour 
{

    [SerializeField] private bool IsPaused;
    [SerializeField] private GameObject PauseMenuUI;

    /* 
    * The update function is called every frame and this function checks if
    * the escape key has been selected and calls the other functions based off the pause state.
    */
    private void Update() 
    {
        //Debug.Log(mainMenu.gamerunning);
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            IsPaused = !IsPaused;
        
            if (IsPaused) 
            {
                ActivateMenu();
            }
            else 
            {
                DeactivateMenu();
            } 
        }     
    }

    /*
    * Function used when we want the menu to be active. 
    * Pauses the game in the background using TimeScale and calls the setactive function passing it true.
    */
    public void ActivateMenu() 
    {
        Time.timeScale = 0;
        PauseMenuUI.SetActive(true);
    }

    /*
    * Function used when we want the menu to be inactive. 
    * Returns the game to be playing using TimeScale and calls the setactive function passing it false.
    */
    public void DeactivateMenu() 
    {
        Time.timeScale = 1;
        PauseMenuUI.SetActive(false);
    }

    /*
    * Function used when quit button is selected. 
    * Stops the audio
    */
    public void QuitGame() 
    {
        Debug.Log("QUIT!");
        AudioManager.Play(AudioLibrary.Library.Select);
    }

    /*
    * Function used when the settings button is selected. 
    * The audio is changed to correspond to the scene change.
    */
    public void SettingGame() 
    {
        SceneManager.LoadScene("SettingsMenu");
        AudioManager.Play(AudioLibrary.Library.Select);
    }

    /*
    * Fucntion used the when the Instructions button is selected.
    */
    public void InstructionsGame()
    {
        SceneManager.LoadScene("InstructionsMenu");
    }

}

