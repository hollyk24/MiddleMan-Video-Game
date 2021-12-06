using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
    [SerializeField] private GameObject SM;

    //public MainMenu mainMenu;
    //public GameObject mainMenu;
    //private MainMenu script;

    private void Update()
    {

        //Debug.Log(mainMenu.gamerunning);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                ActivateMenu();
            }
            else
            {
                DeactivateMenu();
            }
        }

    }

    // private void Start() {
        //  script = mainMenu.GetComponent<MainMenu>();
        //  Debug.Log(script.gamerunning);
        // SM 
    // }
    public void ActivateMenu()
    {
        Debug.Log("Freezing game via ActivateMenu");
        // Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        // Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Destroy(SM);
        SceneManager.LoadScene("MainMenu");
        AudioManager.Play(AudioLibrary.Library.Select);
    }

    public void SettingGame()
    {
        SceneManager.LoadScene("SettingsMenu");
        AudioManager.Play(AudioLibrary.Library.Select);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        AudioManager.Play(AudioLibrary.Library.Select);
    }

    public void InstructionsGame()
    {
        SceneManager.LoadScene("InstructionsMenu");
    }
}
