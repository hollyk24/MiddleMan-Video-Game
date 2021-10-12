
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
            SceneManager.LoadScene("MainMenu");
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
        public IEnumerator HollyTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}


