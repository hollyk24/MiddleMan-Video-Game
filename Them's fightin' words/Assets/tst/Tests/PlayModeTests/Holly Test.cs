
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
            Assert.AreEqual(textbox, "usernameEx");


            

            yield return null;
        }
         
        [UnityTest]
        public IEnumerator SwitchStressTest()
        {
            SceneManager.LoadScene("MainMenu");     //load main menu
            yield return new WaitForSeconds(2);
        
        
            int Count = 1;                          //Variables to track the number of switches
            float waitTime = 1;                     //Time spent waiting during WaitForSeconds
            

            while((int)(1f / Time.unscaledDeltaTime) > 30){     //Loop until the not acceptable frame rate
                SceneManager.LoadScene("SettingsMenu");         //Load the Settings menu
                yield return new WaitForSeconds(waitTime);      //Wait the set time
                SceneManager.LoadScene("MainMenu");             //Switch back to main menu
                 Count++;                                       //Increase the count for the switch
                 yield return null;
                 waitTime = waitTime/10;                        //Decrease the time by dividing by 10
            }
            
            Debug.Log("Number of switches was: " + Count);      //Print out number of switches once it exits the looop / break point
            Debug.Log("Wait time was:" + waitTime);             //Print out the wait time value 
            LogAssert.Expect(LogType.Log, "Number of switches was: " + Count);
            Assert.IsTrue(true);

         

          
        }
        

   
 }
}


