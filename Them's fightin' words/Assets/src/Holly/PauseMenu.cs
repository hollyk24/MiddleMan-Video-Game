using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
    private void Update() {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            isPaused = !isPaused;
           
        }
        if (isPaused) {
            ActivateMenu();
        }
        else {
            DeactivateMenu();
        }
    }

    public void ActivateMenu() {

        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu() {

        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
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
        //SceneManager.LoadScene("InstructionsMenu");
        //Debug.Log("Instructions");
    }

}

