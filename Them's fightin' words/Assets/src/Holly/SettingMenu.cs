using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SettingMenu : MonoBehaviour
{
 
 public InputField mainInputField;
 public string playerName;

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

 void Start(){
  mainInputField.characterLimit = playerName.Length;
 }

 




}
