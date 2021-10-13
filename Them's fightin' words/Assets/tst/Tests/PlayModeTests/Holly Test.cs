
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests{
    
    public class HollyTests{
        
        [SetUp]
        public void loadScene(){
            SceneManager.LoadScene("MainMenu");
        }

        // A Test behaves as an ordinary method
        // [Test]
        // public void SethTestsSimplePasses()
        // {
            // Use the Assert class to test conditions
        // }
        

        [UnityTest]
        public IEnumerator ButtonLocationTest(){
            //SceneManager.LoadScene("MainMenu");
            yield return new WaitForSeconds(2);
            GameObject playButton = GameObject.Find("StartButton");
            Vector3 buttonPos = GameObject.Find("StartButton").transform.position;
            
            Assert.IsTrue((buttonPos.x >= -730 && buttonPos.x <= 730), buttonPos.x.ToString());
            Assert.IsTrue((buttonPos.y <= 400 && buttonPos.y >= -400), buttonPos.y.ToString());
            yield return null;

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator UsernameLength()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            SceneManager.LoadScene("SettingsMenu");
            yield return new WaitForSeconds(3);
            //GameObject username = GameObject.Find("textDisplay");
            var textbox = GameObject.Find("textDisplay").GetComponent("Text");
            yield return new WaitForSeconds(1);
            textbox.ToString();
            //Debug.log(textbox);
            Assert.AreNotEqual(textbox, "usernameEx");


            

            yield return null;
        }
         
        [UnityTest]
        public IEnumerator SettingStressTest()
        {
            SceneManager.LoadScene("MainMenu");
            yield return new WaitForSeconds(2);
        
            var playButton = GameObject.Find("StartButton");
            int buttonCount = 1;

            while((int)(1f / Time.unscaledDeltaTime) > 30){
                 GameObject.Instantiate(playButton);
                 buttonCount++;
                 yield return null;
            }
            Debug.Log("Buttons Spawned by stress test: " + buttonCount);
            LogAssert.Expect(LogType.Log, "Buttons Spawned by stress test: " + buttonCount);
            Assert.IsTrue(true);

         

/*
            bool loadingStarted = false;
            private float timer = 10f;
            private float timer2 = 0f;
            int changecount = 0;
        
            

            while((int)(1f / Time.unscaledDeltaTime) > 30){
                timer2 = timer;
                 timer -= Time.deltaTime;
                 if(timer <= 0f){
                     SceneManager.LoadScene("SettingsMenu");
                 }
                timer2 = timer2 - 1f;
                timer = timer2;
                timer -= Timer.deltaTime;
                if(timer <= 0f){
                    SceneManager.LoadScene("MainMenu");
                }
                timer2 = timer2 - 1f;
                timer = timer2;


            }

            timeElapsed += Time.deltaTime;

            if(timeElapsed > delayBeforeLoading)
            {
                SceneManager.LoadScene("SettingsMenu");
            }
 */           
        }
        

   
 }
}


