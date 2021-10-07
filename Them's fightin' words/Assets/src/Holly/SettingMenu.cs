using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
 
 public void SetVolume (float volume)
 {
     Debug.Log(volume);
 }

 public void BackButton(){
    SceneManager.LoadScene("MainMenu");
     Debug.Log("Back");
 }

 public void CharacterButton(){
   //  SceneManager.LoadScene("CharacterMenu");
     Debug.Log("CharacterMenu");
 }
}
