using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("lilyTestScene");
        Debug.Log("Starting Game");
    }

    public void QuitGame(){

        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void SettingGame(){
        //SceneManager.LoadScene("settingsScene");
        Debug.Log("Settings");
    }
}
